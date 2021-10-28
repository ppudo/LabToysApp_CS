using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace DeltaElektronika.PSC_ETH
{
    public partial class InfoPanel : UserControl
    {
        public InfoPanel( string lang = "" )
        {
            InitializeComponent();

            //set properties for panel and some of elements
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.Dock = DockStyle.Fill;

            //set language version and disable and enable some controls depends on options
            SetLanguage(lang);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Set text elements in panel based on selected language
        /// </summary>
        /// <param name="lang">Selected language</param>
        public void SetLanguage(string lang)
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

            lbVersion.Text = "Version: v" + Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + "." +
                                           Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString() + "." +
                                           Assembly.GetExecutingAssembly().GetName().Version.Build.ToString() + "." +
                                           Assembly.GetExecutingAssembly().GetName().Version.Revision.ToString();
        }

        //-----------------------------------------------------------------------------------------
        public void ChangeLanguage(string lang)
        {
            SetLanguage(lang);
        }

        //-----------------------------------------------------------------------------------------
        private void llClick_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel label = (LinkLabel)sender;

            System.Diagnostics.Process.Start((string)label.Tag);
        }
    }
}
