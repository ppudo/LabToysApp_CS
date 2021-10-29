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
    public partial class SequencerPanel : UserControl
    {
        public SequencerPanel(LabToys.DeltaElektronika.PSC_ETH device, string lang = "")
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

        //-------------------------------------------------------------------------------------------------------------------------------------------
        private void btRefreshCatalog_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            lbCatalog.Items.Clear();
            string[] catalog = device.GetSequenceCatalog();
            if( catalog.Length == 0 )
            {
                return;
            }

            for( int i=0; i<catalog.Length; i++ )
            {
                if( catalog[i] != "" )
                {
                    lbCatalog.Items.Add(catalog[i]);
                }
            }

            Cursor.Current = Cursors.Default;
        }

        //-----------------------------------------------------------------------------------------
        private void lbCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            ListBox box = (ListBox)sender;

            if( box.SelectedItem != null
                && box.SelectedItem.GetType() == typeof( string ) )
            {
                string selectedSequence = (string)box.SelectedItem;
                if( !device.SelectSequence( selectedSequence ) )
                {
                    tbSequenceName.Text = "";
                    return;
                }

                tbSequenceName.Text = selectedSequence;
                return;
            }

            Cursor.Current = Cursors.Default;
        }

        //-----------------------------------------------------------------------------------------
        private void btDeleteSequence_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show( "Are you sure that you want to delete this sequence?", "Delete " + tbSequenceName.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes )
            {
                Cursor.Current = Cursors.WaitCursor;
                if (!device.DeleteSelectedSequence())
                {

                }
                else
                {
                    tbSequenceName.Text = "";
                }
                Cursor.Current = Cursors.Default;
            }
        }

        //-----------------------------------------------------------------------------------------
        private void tbSequenceName_TextChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;

            if( box.Text == "" )
            {
                gbSequenceControl.Enabled = false;
            }
            else
            {
                gbSequenceControl.Enabled = true;

                dgvSequence.Rows.Clear();
                string[] sequence = device.GetCompleteSequence();
                if( sequence.Length == 0 )
                {
                    Cursor.Current = Cursors.Default;
                    return;
                }

                for( int i=0; i<sequence.Length; i++ )
                {
                    int idx = dgvSequence.Rows.Add();
                    DataGridViewRow row = dgvSequence.Rows[idx];
                    row.Cells[0].Value = i + 1;
                    row.Cells[1].Value = sequence[i];
                }
            }

            Cursor.Current = Cursors.Default;
        }

        //-----------------------------------------------------------------------------------------
        private void btPlay_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if ( !device.StartSequence() )
            {

            }
            Cursor.Current = Cursors.Default;
        }

        //-----------------------------------------------------------------------------------------
        private void btPause_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!device.PauseSequence())
            {

            }
            Cursor.Current = Cursors.Default;
        }

        //-----------------------------------------------------------------------------------------
        private void btStop_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!device.StopSequence())
            {

            }
            Cursor.Current = Cursors.Default;
        }
    }
}
