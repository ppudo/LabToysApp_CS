using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabToys.DeltaElektronika;
using System.Threading;

namespace DeltaElektronika.PSC_ETH
{
    public partial class DevicePanel: UserControl
    {
        public DevicePanel( LabToys.DeltaElektronika.PSC_ETH device, string name="PSC_ETH", string lang = "", bool debug=false )
        {
            InitializeComponent();

            //set properties for panel
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.Dock = DockStyle.Fill;

            //save variables
            this.device = device;
            this.debug = debug;
            this.lang = lang;

            //loads panels to tags of buttons
            this.tsbtHome.Tag = new HomePanel(this.device, lang);                                   //each button keep in tag refrece to own panel
            this.tsbtSequencer.Tag = new SequencerPanel(this.device, lang);
            this.tsbtInfo.Tag = new InfoPanel(lang);
            if( this.debug )
            {
                this.tsbtDebug.Tag = new DebugPanel(this.device, lang);
            }

            //save and display default active panel
            this.tsContainer.ContentPanel.Controls.Add( (Control)tsbtHome.Tag );
            this.tsPSC_ETH.Tag = tsbtHome.Tag;                                                      //information about current panel is saved in tag of tool strip

            //set language version and disable and enable some controls depends on options
            SetLanguage(lang);
            tslName.Text = name;

            if (!this.debug)
            {
                tsPSC_ETH.Items.Remove(tsbtDebug);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
        private bool debug = false;
        private string lang = "";
        private LabToys.DeltaElektronika.PSC_ETH device = null;
        private Thread refreshThread = null;

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
            tsbtHome.ToolTipText = Lang.PSC_ETH.DevicePanel.tsbtHome_ToolTip;
            tsbtInfo.ToolTipText = Lang.PSC_ETH.DevicePanel.tsbtInfo_ToolTip;
            tsbtDebug.ToolTipText = Lang.PSC_ETH.DevicePanel.tsbtDebug_ToolTip;
        }

        //-----------------------------------------------------------------------------------------
        public void ChangeLanguage( string lang )
        {
            this.lang = lang;
            SetLanguage(lang);
            ((HomePanel)tsbtHome.Tag).ChangeLanguage(lang);
            ((InfoPanel)tsbtInfo.Tag).ChangeLanguage(lang);
            ((DebugPanel)tsbtDebug.Tag).ChangeLanguage(lang);
        }

        //-----------------------------------------------------------------------------------------
        private void RefreshFunction()
        {
            try
            {
                int messagesDelay = 100;

                while (true)
                {
                    if (device.RefreshDeviceStatus(false))
                    {
                        RefreshPanels();
                    }

                    Thread.Sleep(messagesDelay);
                }
            }
            catch (ThreadAbortException)
            {
                if (device.RefreshDeviceStatus(true))
                {
                    RefreshPanels();
                }
            }
        }

        //-----------------------------------------------------------------------------------------
        private void RefreshPanels()
        {
            ((HomePanel)tsbtHome.Tag).DisplayDeviceStatus();
            ((SequencerPanel)tsbtSequencer.Tag).DisplayDeviceStatus();
        }
        #endregion

        #region ACTION_ITEMS
        //-------------------------------------------------------------------------------------------------------------------------------------------
        private void tsbChangePanel_Click(object sender, EventArgs e)
        {
            ToolStripButton button = (ToolStripButton)sender;

            if( !tsPSC_ETH.Tag.Equals( button.Tag) )
            {   //change panel if you want to change to other panel
                tsContainer.ContentPanel.Controls.Remove((Control)tsPSC_ETH.Tag);
                tsContainer.ContentPanel.Controls.Add((Control)button.Tag);
                tsPSC_ETH.Tag = button.Tag;
            }
        }

        //-----------------------------------------------------------------------------------------
        private void tsbtRefresh_Click(object sender, EventArgs e)
        {
            ToolStripButton btn = (ToolStripButton)sender;

            if (btn.BackColor == SystemColors.ControlDark)
            {
                btn.BackColor = Color.LightGreen;

                if (refreshThread == null)
                {
                    refreshThread = new Thread(new ThreadStart(RefreshFunction))
                    {
                        IsBackground = true
                    };
                }
                refreshThread.Start();
            }
            else
            {
                btn.BackColor = SystemColors.ControlDark;

                refreshThread.Abort();
                refreshThread = null;
            }
        }
        #endregion
    }
}
