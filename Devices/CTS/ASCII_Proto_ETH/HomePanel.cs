using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabToys.CTS;

namespace CTS.ASCII_Proto_ETH
{
    public partial class HomePanel : UserControl
    {
        public HomePanel( LabToys.CTS.ASCII_Proto_ETH device, string lang="" )
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

            //add memories to panel
            for (int i = 0; i < memories.Length; i++)
            {
                lbMemories.Items.Add(memories[i]);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
        private LabToys.CTS.ASCII_Proto_ETH device = null;
        private MemoryData[] memories = new MemoryData[] {  new MemoryData( "M1", -40.0F, 0.0F ),
                                                            new MemoryData( "M2", 25.0F, 50.0F ),
                                                            new MemoryData( "M3", 75.0F, 50.0F ),
                                                            new MemoryData( "M4", 85.0F, 50.0F ) };

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
            
        }

        #endregion

        #region ACTION_ITEMS
        //-------------------------------------------------------------------------------------------------------------------------------------------
        private void btStart_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            Cursor.Current = Cursors.WaitCursor;

            if( btn.BackColor == SystemColors.ControlDark )
            {
                if( device.StartChamber() )
                {
                    btn.BackColor = Color.LightGreen;
                    btn.Text = "Stop";
                }
            }
            else
            {
                if( device.StopChamber() )
                {
                    btn.BackColor = SystemColors.ControlDark;
                    btn.Text = "Start";
                }
            }

            Cursor.Current = Cursors.Default;
        }

        //-----------------------------------------------------------------------------------------
        private void nudTemp_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;

            Cursor.Current = Cursors.WaitCursor;

            if( !device.SetTemp((float)numeric.Value ) )
            {

            }

            Cursor.Current = Cursors.Default;
        }

        //-----------------------------------------------------------------------------------------
        private void lbMemories_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            ListBox box = (ListBox)sender;

            if (box.SelectedItem != null
                && box.SelectedItem.GetType() == typeof(MemoryData))
            {
                MemoryData mem = (MemoryData)box.SelectedItem;
                nudTemp.Value = (decimal)mem.Temp;
                nudHumidity.Value = (decimal)mem.Humidity;
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

        #endregion

        #region
        //-------------------------------------------------------------------------------------------------------------------------------------------
        private class MemoryData
        {
            private float temp = -40.0F;
            private float humidity = 50.0F;
            private string name = "M";

            public float Temp { get => temp; }
            public float Humidity { get => humidity; }
            public string Name { get => name; }

            public MemoryData(string name, float temp, float humidity)
            {
                this.name = name;
                this.temp = temp;
                this.humidity = humidity;
            }

            //------------------------------------------------------------
            public override string ToString()
            {
                return name + ": " + temp.ToString("00.0") + "°C - " + humidity.ToString("0.0") + "%";
            }
        }

        #endregion
    }
}
