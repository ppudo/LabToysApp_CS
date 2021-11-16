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

namespace DeltaElektronika.PSC_ETH
{
    public partial class AddForm : Form
    {
        public AddForm( string lang = "", bool debug = false )
        {
            InitializeComponent();

            //set properties at start
            this.DialogResult = DialogResult.Cancel;
            this.LANGUAGE = lang;
            this.DEBUG = debug;

            //set window language
            SetLanguage(LANGUAGE);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
        private string LANGUAGE = "";
        private bool DEBUG = false;

        //-------------------------------------------------------------------------------------------------------------------------------------------
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

            //-----------------------------------
            //change label in app
            this.Text = Lang.PSC_ETH.AddForm.AddForm_Text;
            this.lbName.Text = Lang.PSC_ETH.AddForm.lbName_Text;
            this.lbIPaddress.Text = Lang.PSC_ETH.AddForm.lbIPaddress_Text;
            this.lbPort.Text = Lang.PSC_ETH.AddForm.lbPort_Text;
            this.btCancel.Text = Lang.PSC_ETH.AddForm.btCancel_Text;
            this.btAdd.Text = Lang.PSC_ETH.AddForm.btAdd_Text;
        }

        //-----------------------------------------------------------------------------------------
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //-----------------------------------------------------------------------------------------
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbIPaddress.Text == "")
            {
                //if no ip return error
                MessageBox.Show(Lang.PSC_ETH.AddForm.WrongIPAddress_Text, Lang.PSC_ETH.AddForm.WrongIPAddress_Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }                                            

            this.Tag = new DevicePanel(new LabToys.DeltaElektronika.PSC_ETH(tbIPaddress.Text, (ushort)nudPort.Value), tbName.Text, LANGUAGE, DEBUG);

            this.Text = tbName.Text;                        //save name of device in form Text
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
