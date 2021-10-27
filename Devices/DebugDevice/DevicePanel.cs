using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabToys;
using System.Reflection;

namespace DebugDevice
{
    public partial class DevicePanel: UserControl
    {
        public DevicePanel( string lang = "" )
        {
            InitializeComponent();

            //set properties for panel
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.Dock = DockStyle.Fill;

            //save variables
            this.lang = lang;

            //set language version and disable and enable some controls depends on options
            SetLanguage(lang);

            lbVersion.Text = "Version: v" + Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + "." +
                                           Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString() + "." +
                                           Assembly.GetExecutingAssembly().GetName().Version.Build.ToString() + "." +
                                           Assembly.GetExecutingAssembly().GetName().Version.Revision.ToString();
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
        private string lang = "";
        private SCPIsocket lanDevice = null;

        //-------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Set text elements in panel based on selected language
        /// </summary>
        /// <param name="lang">Selected language</param>
        private void SetLanguage(string lang)
        {
            if (lang == "")
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.InstalledUICulture.Name);
            }
            else
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            }

            //change label in panel
        }

        //-----------------------------------------------------------------------------------------
        public void ChangeLanguage(string lang)
        {
            this.lang = lang;
            SetLanguage(lang);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
        private void btLanCreate_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (lanDevice == null)
            {
                lanDevice = new SCPIsocket(tbLanIP.Text, (ushort)nudLanPort.Value);
                gbHost.Enabled = false;
                btn.BackColor = Color.LightGreen;
            }
            else
            {
                lanDevice = null;
                gbHost.Enabled = true;
                btn.BackColor = Color.Gray;
            }
        }

        //-----------------------------------------------------------------------------------------
        private void btLanConnect_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (lanDevice != null)
            {
                if (btn.BackColor == Color.Red)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    if (lanDevice.Connect() == true)
                    {
                        btn.BackColor = Color.LightGreen;
                        btn.Text = "Disconnect";
                    }
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    lanDevice.Close();
                    btn.BackColor = Color.Red;
                    btn.Text = "Connect";
                }
            }
            else
            {
                tbLanError.Text = "device is null";
            }
        }

        //-----------------------------------------------------------------------------------------
        private void btLanSend_Click(object sender, EventArgs e)
        {
            if( lanDevice != null )
            {
                if( tbLanInput.Text.Length > 0 )
                {
                    Cursor.Current = Cursors.WaitCursor;
                    tbLanError.Text = "";

                    if (tbLanInput.Text[tbLanInput.Text.Length - 1] == '?')
                    {
                        string ans = lanDevice.SendCommandGetAns(tbLanInput.Text, chbLanStayConnected.Checked);
                        if( ans.Length == 0 )
                        {
                            tbLanError.Text = "ans is empty";
                        }
                        else
                        {
                            tbLanOutput.Text = ans;
                        }
                    }
                    else
                    {
                        bool status = lanDevice.SendCommand(tbLanInput.Text, chbLanStayConnected.Checked);
                        if (status == false)
                        {
                            tbLanOutput.Text = "status == false";
                            tbLanError.Text = "status == false";
                        }
                        else
                        {
                            tbLanOutput.Text = "status == true";
                        }
                    }

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    tbLanError.Text = "input is empty";
                }
            }
            else
            {
                tbLanError.Text = "device is null";
            }
        }

        //-----------------------------------------------------------------------------------------
        private void chbLanEnding_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;

            if (box.Checked)
            {
                if (box != chbLanEndingNL)
                {
                    chbLanEndingNL.Checked = false;
                }

                if (box != chbLanEndingCR)
                {
                    chbLanEndingCR.Checked = false;
                }

                if (box != chbLanEndingNLCR)
                {
                    chbLanEndingNLCR.Checked = false;
                }

                if (box != chbLanEndingCRNL)
                {
                    chbLanEndingCRNL.Checked = false;
                }

                if( box != chbLanEndingCustom )
                {
                    chbLanEndingCustom.Checked = false;
                }
            }
        }

        //-----------------------------------------------------------------------------------------
        private void btLanDebug1_Click(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------
        private void btLanDebug2_Click(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------
        private void btLanDebug3_Click(object sender, EventArgs e)
        {

        }
    }
}
