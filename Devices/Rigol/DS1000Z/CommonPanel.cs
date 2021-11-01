using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabToys.Rigol;

namespace Rigol.DS1000Z
{
    public partial class CommonPanel : UserControl
    {
        public CommonPanel(LabToys.Rigol.DS1000Z device, string lang = "")
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
        private LabToys.Rigol.DS1000Z device = null;

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
            lbTitle.Text = Lang.DS1000Z.CommonPanel.lbTitle_Text;
            gbIDN.Text = Lang.DS1000Z.CommonPanel.gbIDN_Text;
            lbManufacturer.Text = Lang.DS1000Z.CommonPanel.lbManufacturer_Text;
            lbModel.Text = Lang.DS1000Z.CommonPanel.lbModel_Text;
            lbSerialNumber.Text = Lang.DS1000Z.CommonPanel.lbSerialNumber_Text;
            lbRevisionCode.Text = Lang.DS1000Z.CommonPanel.lbRevisionCode_Text;
            btClear.Text = Lang.DS1000Z.CommonPanel.btClear_Text;
            lbClearStatus.Text = Lang.DS1000Z.CommonPanel.lbClearStatus_Text;
            lbRestore.Text = Lang.DS1000Z.CommonPanel.lbResotre_Text;
            lbSelfTest.Text = Lang.DS1000Z.CommonPanel.lbSelfTest_Text;
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
            if (respond.Length == 4)
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
        private void btClearStatus_Click(object sender, EventArgs e)
        {
            device.ClearStatus();
        }

        //-----------------------------------------------------------------------------------------
        private void btRestore_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Lang.DS1000Z.CommonPanel.Restore_message, Lang.DS1000Z.CommonPanel.Restore_caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                device.RestoreToDefaultState();
            }
        }

        //-----------------------------------------------------------------------------------------
        private void btSelfTest_Click(object sender, EventArgs e)
        {
            int ans = device.SelfTest();
            tbSelfTest.Text = ans.ToString() + " = 0x" + ans.ToString("X2");
        }
        #endregion
    }
}
