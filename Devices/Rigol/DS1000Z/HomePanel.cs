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
using System.IO;

namespace Rigol.DS1000Z
{
    public partial class HomePanel : UserControl
    {
        public HomePanel( LabToys.Rigol.DS1000Z device, string lang="" )
        {
            InitializeComponent();

            //set properties for panel and some of elements
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.Dock = DockStyle.Fill;

            //save variables
            this.device = device;

            //set language version and disable and enable some controls depends on options
            SetLanguage(lang);

            tbScreenFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            cbScreenFormat.Items.Add("BMP");
            cbScreenFormat.SelectedIndex = 0;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
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
            lbTitle.Text = Lang.DS1000Z.HomePanel.lbTitle_Text;

            btAuto.Text = Lang.DS1000Z.HomePanel.btAuto_Text;
            btClear.Text = Lang.DS1000Z.HomePanel.btClear_Text;
            btRun.Text = Lang.DS1000Z.HomePanel.btRun_Text;
            btStop.Text = Lang.DS1000Z.HomePanel.btStop_Text;
            btSingle.Text = Lang.DS1000Z.HomePanel.btSingle_Text;
            btForce.Text = Lang.DS1000Z.HomePanel.btForce_Text;

            btSaveScreen.Text = Lang.DS1000Z.HomePanel.btSaveScreen_Text;
            gbScreen.Text = Lang.DS1000Z.HomePanel.gbScreen_Text;
            lbScreenFolder.Text = Lang.DS1000Z.HomePanel.lbScreenFolder_Text;
            lbScreenName.Text = Lang.DS1000Z.HomePanel.lbScreenName_Text;
            btScreenBrowse.Text = Lang.DS1000Z.HomePanel.btScreenBrowse_Text;
            lbScreenNo.Text = Lang.DS1000Z.HomePanel.lbScreenNo_Text;
        }

        //-----------------------------------------------------------------------------------------
        public void ChangeLanguage(string lang)
        {
            SetLanguage(lang);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
        private void btAuto_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if ( !device.Autoscale() )
            {

            }

            Cursor.Current = Cursors.Default;
        }

        //-----------------------------------------------------------------------------------------
        private void btClear_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if ( !device.Clear() )
            {

            }

            Cursor.Current = Cursors.Default;
        }

        //-----------------------------------------------------------------------------------------
        private void btRun_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (!device.Run())
            {

            }

            Cursor.Current = Cursors.Default;
        }

        //-----------------------------------------------------------------------------------------
        private void btStop_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (!device.Stop())
            {

            }

            Cursor.Current = Cursors.Default;
        }

        //-----------------------------------------------------------------------------------------
        private void btSingle_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (!device.Single())
            {

            }

            Cursor.Current = Cursors.Default;
        }

        //-----------------------------------------------------------------------------------------
        private void btForce_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (!device.TriggerForce())
            {

            }

            Cursor.Current = Cursors.Default;
        }

        //-----------------------------------------------------------------------------------------
        private void btSaveScreen_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string path = tbScreenFolder.Text + "\\" + tbScreenName.Text + "_" + nudScreenNo.Value.ToString("000");
            switch (cbScreenFormat.SelectedIndex)
            {
                case 0:
                    path = path + ".bmp";
                    break;
                default:
                    path = path + ".bmp";
                    break;
            }

            if( !device.SaveScreenToImage(path) )
            {
                
            }
            nudScreenNo.Value++;

            Cursor.Current = Cursors.Default;
        }

        //-----------------------------------------------------------------------------------------
        private void btScreenBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = tbScreenFolder.Text;
            if( dialog.ShowDialog() == DialogResult.OK )
            {
                tbScreenFolder.Text = dialog.SelectedPath;
            }
        }

        //-----------------------------------------------------------------------------------------
        private void tbScreen_TextChanged(object sender, EventArgs e)
        {
            //TextBox box = (TextBox)sender;
            DirectoryInfo directory = new DirectoryInfo(tbScreenFolder.Text);
            FileInfo[] files = directory.GetFiles(tbScreenName.Text + "_*.bmp");

            uint maxNum = 0;
            for (int i = 0; i < files.Length; i++)
            {
                uint num = 0;
                if (uint.TryParse(files[i].Name.TrimStart((tbScreenName.Text + "_").ToCharArray()).TrimEnd(".bmp".ToCharArray()), out num))
                {
                    if (num >= maxNum)
                    {
                        maxNum = num + 1;
                    }
                }
            }

            nudScreenNo.Value = maxNum;
        }
    }
}
