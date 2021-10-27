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

namespace LabToysApp
{
    public partial class AboutForm : Form
    {
        public AboutForm( string lang = "" )
        {
            InitializeComponent();

            //set language version
            SetLanguage(lang);
        }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Set text elements in app based on selected language
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

            //change label in app
            this.Text = Lang.AboutForm.AboutForm_Text;
            lbAppName.Text = Lang.AboutForm.lbAppName_Text;
            lbAuthor.Text = Lang.AboutForm.lbAuthor_Text;
            lbVersion.Text = Lang.AboutForm.lbVersion_Text + " v" + Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + "." +
                                                                    Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString() + "." +
                                                                    Assembly.GetExecutingAssembly().GetName().Version.Build.ToString() + "." +
                                                                    Assembly.GetExecutingAssembly().GetName().Version.Revision.ToString();
            gbImagesAuthors.Text = Lang.AboutForm.gbImagesAuthors_Text;
        }

        //-----------------------------------------------------------------------------------------
        public void ChangeLanguage( string lang )
        {
            SetLanguage(lang);
        }

        //*******************************************************************************************************************************************
        private void llClick_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel label = (LinkLabel)sender;

            System.Diagnostics.Process.Start((string)label.Tag);
        }
    }
}
