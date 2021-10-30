using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabToys.DeltaElektronika;
using System.IO;

namespace DeltaElektronika.PSC_ETH
{
    public partial class HomePanel : UserControl
    {
        public HomePanel(LabToys.DeltaElektronika.PSC_ETH device, string lang="" )
        {
            InitializeComponent();

            //set properties for panel and some of elements
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.Dock = DockStyle.Fill;

            //save variables
            this.device = device;

            //set language version and disable and enable some controls depends on options
            SetLanguage(lang);

            //set some variables
            digitalInputs = new TextBox[] { tbInputA, tbInputB, tbInputC, tbInputD, tbInputE, tbInputF, tbInputG, tbInputH };
            digitalOutputs = new Button[] { btOutputA, btOutputB, btOutputC, btOutputD, btOutputE, btOutputF };
            for( int i=0; i<digitalOutputs.Length; i++ )
            {
                digitalOutputs[i].Tag = (int)i;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
        private LabToys.DeltaElektronika.PSC_ETH device = null;
        private TextBox[] digitalInputs = null;
        private Button[] digitalOutputs = null;

        #region FUNCTIONS
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
            SetLanguage(lang);
        }

        //-----------------------------------------------------------------------------------------
        public void DisplayDeviceStatus()
        {
            if (!float.IsNaN(device.DeviceStatus.MeasuredVoltage))
            {
                SetTextControl(tbMeasuredVoltage, device.DeviceStatus.MeasuredVoltage.ToString("0.0000") + " V");
            }
            if (!float.IsNaN(device.DeviceStatus.MeasuredCurrent))
            {
                SetTextControl(tbMeasuredCurrent, device.DeviceStatus.MeasuredCurrent.ToString("0.0000") + " A");
            }

            //-----------------------------------
            if (device.DeviceStatus.DigitalOutputs != int.MinValue)
            {
                for( int i=0; i<digitalOutputs.Length; i++ )
                {
                    if ((device.DeviceStatus.DigitalOutputs & (1 << i)) != 0)
                    {
                        SetTextControl(digitalOutputs[i], "1");
                        SetControlBackColor(digitalOutputs[i], Color.YellowGreen);
                    }
                    else
                    {
                        SetTextControl(digitalOutputs[i], "0");
                        SetControlBackColor(digitalOutputs[i], SystemColors.ControlDark);
                    }
                }
            }

            //-----------------------------------
            if (device.DeviceStatus.DigitalInputs != int.MinValue)
            {
                for (int i = 0; i < digitalInputs.Length; i++)
                {
                    if ((device.DeviceStatus.DigitalInputs & (1 << i)) != 0)
                    {
                        SetTextControl(digitalInputs[i], "1");
                        SetControlBackColor(digitalInputs[i], Color.YellowGreen);
                    }
                    else
                    {
                        SetTextControl(digitalInputs[i], "0");
                        SetControlBackColor(digitalInputs[i], SystemColors.ControlDark);
                    }
                }
            }
        }

        #endregion

        #region ACTION_ITEMS
        //-------------------------------------------------------------------------------------------------------------------------------------------
        private void btOutput_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            Cursor.Current = Cursors.WaitCursor;

            if ( btn.BackColor == SystemColors.ControlDark )
            {
                if( device.EnableOutput() )
                {
                    btn.BackColor = Color.Red;
                    btn.Text = "Output ON";
                }
            }
            else
            {
                if( device.DisableOutput() )
                {
                    btn.BackColor = SystemColors.ControlDark;
                    btn.Text = "Output OFF";
                }
            }

            Cursor.Current = Cursors.Default;
        }

        //-----------------------------------------------------------------------------------------
        private void nudVoltage_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;

            Cursor.Current = Cursors.WaitCursor;

            if ( !device.SetOutputVoltage((float)numeric.Value) )
            {

            }

            Cursor.Current = Cursors.Default;
        }

        //-----------------------------------------------------------------------------------------
        private void nudCurrent_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;

            Cursor.Current = Cursors.WaitCursor;

            if (!device.SetOutputCurrent((float)numeric.Value))
            {

            }

            Cursor.Current = Cursors.Default;
        }

        //-----------------------------------------------------------------------------------------
        private void btOutputX_Click(object sender, EventArgs e)
        {
            //get idx
            Button btn = (Button)sender;
            int mask = 1 << (int)btn.Tag;

            Cursor.Current = Cursors.WaitCursor;

            //read current state
            int state = device.GetDigitalOutputs();
            if( state == int.MinValue )
            {
                Cursor.Current = Cursors.Default;
                return;
            }

            //set state
            if (btn.Text == "0")
            {   //set - set to '1'
                state = state | mask;
            }
            else
            {   //clear - set to '0'
                state = state & ~mask;
            }

            //send new state
            if( !device.SetDigitalOutputs(state) )
            {
                Cursor.Current = Cursors.Default;
                return;
            }

            //set new button status
            if (btn.Text == "0")
            {   //set - set to '1'
                btn.Text = "1";
                btn.BackColor = Color.YellowGreen;
            }
            else
            {   //clear - set to '0'
                btn.Text = "0";
                btn.BackColor = SystemColors.ControlDark;
            }

            Cursor.Current = Cursors.Default;
        }

        //-----------------------------------------------------------------------------------------
        private void btRemoteVoltage_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Cursor.Current = Cursors.WaitCursor;

            if( btn.Text == "Local" )
            {
                if( device.SetRemoteVoltage(LabToys.DeltaElektronika.PSC_ETH.RemoteStatus.REMOTE ) )
                {
                    btn.Text = "Remote";
                    btn.BackColor = Color.LightGreen;
                }
                else
                {

                }
            }
            else
            {
                if (device.SetRemoteVoltage(LabToys.DeltaElektronika.PSC_ETH.RemoteStatus.LOCAL))
                {
                    btn.Text = "Local";
                    btn.BackColor = SystemColors.ControlDark;
                }
                else
                {

                }
            }

            Cursor.Current = Cursors.Default;
        }

        //-----------------------------------------------------------------------------------------
        private void btRemoteCurrent_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Cursor.Current = Cursors.WaitCursor;

            if (btn.Text == "Local")
            {
                if (device.SetRemoteCurrent(LabToys.DeltaElektronika.PSC_ETH.RemoteStatus.REMOTE))
                {
                    btn.Text = "Remote";
                    btn.BackColor = Color.LightGreen;
                }
                else
                {

                }
            }
            else
            {
                if (device.SetRemoteCurrent(LabToys.DeltaElektronika.PSC_ETH.RemoteStatus.LOCAL))
                {
                    btn.Text = "Local";
                    btn.BackColor = SystemColors.ControlDark;
                }
                else
                {

                }
            }

            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region DELEGATES
        //-------------------------------------------------------------------------------------------------------------------------------------------
        //  DDDD  EEEEE L     EEEEE  GGG    A   TTTTT EEEEE  SSS
        //  D   D E     L     E     G      A A    T   E     S
        //  D   D EEE   L     EEE   G  GG A   A   T   EEE    SSS
        //  D   D E     L     E     G   G AAAAA   T   E         S
        //  DDDD  EEEEE LLLLL EEEEE  GGG  A   A   T   EEEEE  SSS
        //

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

        //-----------------------------------------------------------------------------------------
        private delegate void SetControlBackColorDelegate( Control control, Color newColor );

        private void SetControlBackColor(Control control, Color color)
        {
            if (control.InvokeRequired)
            {
                SetControlBackColorDelegate d = new SetControlBackColorDelegate(SetControlBackColor);
                this.Invoke(d, new object[] { control, color });
            }
            else
            {
                control.BackColor = color;
            }
        }

        #endregion
    }
}
