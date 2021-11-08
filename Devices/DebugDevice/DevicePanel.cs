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
using System.Threading;

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

        int connIdx = 0;
        int freeIdx = 0;
        //-----------------------------------------------------------------------------------------
        private void btLanConnect_Click(object sender, EventArgs e)
        {
            if (lanDevice != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                if( freeIdx == 0
                    && connIdx == 0 )
                {
                    connIdx = lanDevice.Connect();
                }
                else if( connIdx == 0 )
                {
                    connIdx = lanDevice.Connect(freeIdx);
                }
                else
                {
                    tbLanError.Text = "current idx status" + Environment.NewLine
                                    + "connIdx: " + connIdx.ToString() + Environment.NewLine
                                    + "freeIdx: " + freeIdx.ToString() + Environment.NewLine;
                }

                if (connIdx != -1 )
                {
                    btLanConnect.BackColor = Color.LightGreen;
                    btFree.Enabled = true;
                    btClose.Enabled = true;
                }
                else
                {
                    connIdx = 0;
                }
                Cursor.Current = Cursors.Default;
            }
            else
            {
                tbLanError.Text = "device is null";
            }
        }

        //-----------------------------------------------------------------------------------------
        private void btFree_Click(object sender, EventArgs e)
        {
            if( lanDevice != null )
            {
                lanDevice.Free(connIdx);
                freeIdx = connIdx;
                connIdx = 0;

                btFree.Enabled = false;
                btLanConnect.BackColor = Color.Gold;
            }
            else
            {
                tbLanError.Text = "device is null";
            }
        }

        //-----------------------------------------------------------------------------------------
        private void btClose_Click(object sender, EventArgs e)
        {
            if (lanDevice != null)
            {
                if (freeIdx != 0)
                {
                    lanDevice.Close(freeIdx);
                }
                else
                {
                    lanDevice.Close(connIdx);
                }
                btLanConnect.BackColor = Color.Red;
                btFree.Enabled = false;
                btClose.Enabled = false;

                connIdx = 0;
                freeIdx = 0;
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
                        string ans = lanDevice.SendCommandGetAns(tbLanInput.Text, chbLanStayConnected.Checked, connIdx);
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
                        int idx = lanDevice.SendCommand(tbLanInput.Text, chbLanStayConnected.Checked, connIdx);
                        if ( idx == -1 )
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
            if (loopEnable)
            {
                //loopThread.Abort();
                //loopThread = null;
                loopEnable = false;
            }
            else
            {
                if (loopThread == null)
                {
                    loopThread = new Thread(new ThreadStart(LoopFunction))
                    {
                        IsBackground = true
                    };
                    loopEnable = true;
                }
                loopThread.Start();
            }
        }

        //-----------------------------------------------------------------------------------------
        private void btLanDebug2_Click(object sender, EventArgs e)
        {
            if (loopEnable2)
            {
                //loopThread2.Abort();
                //loopThread2 = null;
                loopEnable2 = false;
            }
            else
            {
                if (loopThread2 == null)
                {
                    loopThread2 = new Thread(new ThreadStart(LoopFunction2))
                    {
                        IsBackground = true
                    };
                    loopEnable2 = true;
                }
                loopThread2.Start();
            }
        }

        //-----------------------------------------------------------------------------------------
        private void btLanDebug3_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
        //DEBUG FUNCTIONS

        private int loopIdx = 0;
        private int loopConnIdx = 0;
        private bool loopEnable = false;
        private Thread loopThread = null;

        private int loopIdx2 = 0;
        private int loopConnIdx2 = 0;
        private bool loopEnable2 = false;
        private Thread loopThread2 = null;

        private void LoopFunction()
        {
            int messagesDelay = 100;

            while (loopEnable)
            {
                if (GetDeviceData(false))
                {
                    loopIdx++;
                    SetTextControl(tbDebugInfo, "Loop idx (1): " + loopIdx.ToString() + Environment.NewLine
                                                    + "Loop idx (2): " + loopIdx2.ToString());
                }
                Thread.Sleep(messagesDelay);
            }

            if (GetDeviceData(true))
            {
                loopIdx++;
                SetTextControl(tbDebugInfo, "Loop idx (1): " + loopIdx.ToString() + Environment.NewLine
                                            + "Loop idx (2): " + loopIdx2.ToString());
            }

            try
            {
                loopThread.Abort();
            }
            catch (ThreadAbortException)
            {
                loopThread = null;
            }
        }

        //-----------------------------------------------------------------------------------------
        private void LoopFunction2()
        {
            int messagesDelay = 100;

            while (loopEnable2)
            {
                if (GetDeviceData2(false))
                {
                    loopIdx2++;
                    SetTextControl(tbDebugInfo, "Loop idx (1): " + loopIdx.ToString() + Environment.NewLine
                                                    + "Loop idx (2): " + loopIdx2.ToString());
                }
                Thread.Sleep(messagesDelay);
            }

            if (GetDeviceData2(true))
            {
                loopIdx2++;
                SetTextControl(tbDebugInfo, "Loop idx (1): " + loopIdx.ToString() + Environment.NewLine
                                            + "Loop idx (2): " + loopIdx2.ToString());
            }

            try
            {
                loopThread2.Abort();
            }
            catch (ThreadAbortException)
            {
                loopThread2 = null;
            }
        }

        //-----------------------------------------------------------------------------------------
        private bool GetDeviceData( bool closeConnection )
        {
            loopConnIdx = lanDevice.Connect(loopConnIdx);
            if (loopConnIdx == (int)SCPIsocket.ConnectionIdx.ERROR)
            {
                loopConnIdx = (int)SCPIsocket.ConnectionIdx.NO_IDX;
                return false;
            }

            string ans = lanDevice.SendCommandGetAns("*IDN?", false, loopConnIdx);
            ans = lanDevice.SendCommandGetAns("*TST?", false, loopConnIdx);

            if (closeConnection)
            {
                lanDevice.Close(loopConnIdx);
                loopConnIdx = (int)SCPIsocket.ConnectionIdx.NO_IDX;
            }
            else
            {
                lanDevice.Free(loopConnIdx);
            }

            return true;
        }

        //-----------------------------------------------------------------------------------------
        private bool GetDeviceData2(bool closeConnection)
        {
            loopConnIdx2 = lanDevice.Connect(loopConnIdx2);
            if (loopConnIdx2 == (int)SCPIsocket.ConnectionIdx.ERROR)
            {
                loopConnIdx2 = (int)SCPIsocket.ConnectionIdx.NO_IDX;
                return false;
            }

            string ans = lanDevice.SendCommandGetAns("*IDN?", false, loopConnIdx2);
            ans = lanDevice.SendCommandGetAns("*TST?", false, loopConnIdx2);

            if (closeConnection)
            {
                lanDevice.Close(loopConnIdx2);
                loopConnIdx2 = (int)SCPIsocket.ConnectionIdx.NO_IDX;
            }
            else
            {
                lanDevice.Free(loopConnIdx2);
            }

            return true;
        }

        //-----------------------------------------------------------------------------------------
        private delegate void SetTextControlDelegate(Control control, string text);

        private void SetTextControl(Control control, string text)
        {
            if (control.InvokeRequired)
            {
                SetTextControlDelegate d = new SetTextControlDelegate(SetTextControl);
                this.Invoke(d, new object[] { control, text });
            }
            else
            {
                control.Text = text;
            }
        }
    }
}
