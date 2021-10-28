using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabToys.Rigol;

namespace Rigol.DS1000Z
{
    public partial class DevicePanel: UserControl
    {
        public DevicePanel( LabToys.Rigol.DS1000Z device, string name="Rigol DS1000Z", string lang = "", bool debug=false )
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
            this.tsbtInfo.Tag = new InfoPanel(lang);
            if( this.debug )
            {
                this.tsbtDebug.Tag = new DebugPanel(this.device, lang);
            }

            //save and display default active panel
            this.tsContainer.ContentPanel.Controls.Add( (Control)tsbtHome.Tag );
            this.tsDS1000Z.Tag = tsbtHome.Tag;                                                      //information about current panel is saved in tag of tool strip

            //set language version and disable and enable some controls depends on options
            SetLanguage(lang);
            tslName.Text = name;

            if (!this.debug)
            {
                tsDS1000Z.Items.Remove(tsbtDebug);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
        private bool debug = false;
        private string lang = "";
        private LabToys.Rigol.DS1000Z device = null;

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
            tsbtHome.ToolTipText = Lang.DS1000Z.DevicePanel.tsbtHome_ToolTip;
            tsbtInfo.ToolTipText = Lang.DS1000Z.DevicePanel.tsbtInfo_ToolTip;
            tsbtDebug.ToolTipText = Lang.DS1000Z.DevicePanel.tsbtDebug_ToolTip;
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
        private void tsbChangePanel_Click(object sender, EventArgs e)
        {
            ToolStripButton button = (ToolStripButton)sender;

            if( !tsDS1000Z.Tag.Equals( button.Tag) )
            {   //change panel if you want to change to other panel
                tsContainer.ContentPanel.Controls.Remove((Control)tsDS1000Z.Tag);
                tsContainer.ContentPanel.Controls.Add((Control)button.Tag);
                tsDS1000Z.Tag = button.Tag;
            }
        }
    }
}
