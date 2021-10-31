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
    public partial class CommonPanel : UserControl
    {
        public CommonPanel(LabToys.DeltaElektronika.PSC_ETH device, string lang = "")
        {
            InitializeComponent();

            //set properties for panel and some of elements
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.Dock = DockStyle.Fill;

            //save variables
            this.device = device;

            //set language version and disable and enable some controls depends on options
            SetLanguage(lang);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
        private LabToys.DeltaElektronika.PSC_ETH device = null;

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
            lbTitle.Text = Lang.PSC_ETH.CommonPanel.lbTitle_Text;
            gbIDN.Text = Lang.PSC_ETH.CommonPanel.gbIDN_Text;
            lbManufacturer.Text = Lang.PSC_ETH.CommonPanel.lbManufacturer_Text;
            lbModel.Text = Lang.PSC_ETH.CommonPanel.lbModel_Text;
            lbSerialNumber.Text = Lang.PSC_ETH.CommonPanel.lbSerialNumber_Text;
            lbRevisionCode.Text = Lang.PSC_ETH.CommonPanel.lbRevisionCode_Text;
            btClear.Text = Lang.PSC_ETH.CommonPanel.btClear_Text;
            lbRestore.Text = Lang.PSC_ETH.CommonPanel.lbResotre_Text;
            lbRecallCalibration.Text = Lang.PSC_ETH.CommonPanel.lbRecallCalibration_Text;
            lbUserData.Text = Lang.PSC_ETH.CommonPanel.lbUserData_Text;
        }

        //-----------------------------------------------------------------------------------------
        public void ChangeLanguage(string lang)
        {
            SetLanguage(lang);
        }

        #endregion

        #region ACTION_ITEMS
        //-------------------------------------------------------------------------------------------------------------------------------------------
        private void btIDN_Click(object sender, EventArgs e)
        {
            string[] respond = device.GetIDN();
            if( respond.Length == 4 )
            {
                tbManufacturer.Text = respond[0];
                tbModel.Text = respond[1];
                tbSerialNumber.Text = respond[2];
                tbRevisionCode.Text = respond[3];
            }
            else
            {
                btClear_Click(btClear, new EventArgs());
            }
        }

        //-----------------------------------------------------------------------------------------
        private void btClear_Click(object sender, EventArgs e)
        {
            tbManufacturer.Text = "";
            tbModel.Text = "";
            tbSerialNumber.Text = "";
            tbRevisionCode.Text = "";
        }

        //-----------------------------------------------------------------------------------------
        private void btRestore_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Lang.PSC_ETH.CommonPanel.Restore_message, Lang.PSC_ETH.CommonPanel.Restore_caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                device.RestoreToDefaultState();
            }
        }

        //-----------------------------------------------------------------------------------------
        private void btRecallCalibration_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Lang.PSC_ETH.CommonPanel.Calibration_message, Lang.PSC_ETH.CommonPanel.Calibration_caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                device.RestoreToDefaultState();
            }
        }

        //-----------------------------------------------------------------------------------------
        private void btGetPud_Click(object sender, EventArgs e)
        {
            string pud = device.GetProtectedUserData();
            tbGetPud.Text = pud;
        }

        //-----------------------------------------------------------------------------------------
        private void btSetPud_Click(object sender, EventArgs e)
        {
            if (tbSetPud.Text.Length > 0)
            {
                if (MessageBox.Show(Lang.PSC_ETH.CommonPanel.PUD_message, Lang.PSC_ETH.CommonPanel.PUD_caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    device.SetProtectedUserData(tbSetPud.Text);
                }
            }
        }

        #endregion
    }
}
