using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeltaElektronika.PSC_ETH
{
    public partial class EditSequenceForm : Form
    {
        public EditSequenceForm(string lang = "", string sequenceName = "New_sequence", string[] steps = null )
        {
            InitializeComponent();

            //set language version and disable and enable some controls depends on options
            SetLanguage(lang);

            //fill controls
            tbSequenceName.Text = sequenceName;
            if( steps == null )
            {
                steps = new string[0];
            }
            dgvSequence.Tag = steps;

            for (int i = 0; i < steps.Length; i++)
            {
                int idx = dgvSequence.Rows.Add();
                DataGridViewRow row = dgvSequence.Rows[idx];
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = steps[i];
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
        public string SequenceName { get => tbSequenceName.Text; }
        public string[] SequenceSteps { get => (string[])dgvSequence.Tag; }

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
        #endregion

        #region ACTION_ITEMS
        //-------------------------------------------------------------------------------------------------------------------------------------------
        private void dgvSequence_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow row = dgvSequence.Rows[e.Row.Index - 1];

            row.Cells[0].Value = row.Index + 1;
            for( int i=0; i<row.Cells.Count; i++ )
            {
                row.Cells[i].Style.BackColor = Color.Orange;
            }
        }

        //-----------------------------------------------------------------------------------------
        private void dgvSequence_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            //recalculate rows indexes
            int idx = (int)e.Row.Cells[0].Value - 1;

            for( int i=idx; i<dgvSequence.Rows.Count; i++ )
            {
                DataGridViewRow row = dgvSequence.Rows[i];
                row.Cells[0].Value = row.Index + 1;
            }

            //remove idx value from last cell
            dgvSequence.Rows[dgvSequence.Rows.Count - 1].Cells[0].Value = null;
        }

        //-----------------------------------------------------------------------------------------
        private void btDeleteRow_Click(object sender, EventArgs e)
        {
            //delete rows and find startIdx
            int count = dgvSequence.SelectedRows.Count;
            int startIdx = int.MaxValue;
            for ( int i=0; i<count; i++ )
            {
                int idx = dgvSequence.SelectedRows[0].Cells[0].RowIndex;
                if( idx != (dgvSequence.Rows.Count-1))
                {
                    if (idx < startIdx)
                    {
                        startIdx = idx;
                    }
                    dgvSequence.Rows.Remove(dgvSequence.SelectedRows[0]);
                }
            }

            //recalculate new rows indexes
            for( int i=startIdx; i<dgvSequence.Rows.Count; i++ )
            {
                DataGridViewRow row = dgvSequence.Rows[i];
                row.Cells[0].Value = row.Index + 1;
            }

            //remove idx value from last cell
            dgvSequence.Rows[dgvSequence.Rows.Count - 1].Cells[0].Value = null;
        }

        //-----------------------------------------------------------------------------------------
        private void btAddRow_Click(object sender, EventArgs e)
        {
            if( dgvSequence.SelectedCells.Count > 0 )
            {
                int idx = dgvSequence.SelectedCells[0].RowIndex;
                dgvSequence.Rows.Add();

                //move cells down
                for( int i=dgvSequence.Rows.Count-1; i>idx; i-- )
                {
                    DataGridViewRow rowNew = dgvSequence.Rows[i];
                    DataGridViewRow rowOld = dgvSequence.Rows[i-1];

                    if( rowOld.Cells[0].Value == null )
                    {
                        rowOld.Cells[0].Value = rowOld.Index + 1;
                    }
                    rowNew.Cells[0].Value = (int)rowOld.Cells[0].Value + 1;
                    rowNew.Cells[1].Value = rowOld.Cells[1].Value;
                    rowOld.Cells[1].Value = null;
                    for ( int j=0; j<rowOld.Cells.Count; j++ )
                    {
                        rowNew.Cells[j].Style.BackColor = rowOld.Cells[j].Style.BackColor;
                    }
                }

                dgvSequence.Rows[dgvSequence.Rows.Count - 1].Cells[0].Value = null;                 //clear last cell
                //change color of added cell
                for (int j = 0; j < dgvSequence.Rows[idx].Cells.Count; j++)
                {
                    dgvSequence.Rows[idx].Cells[j].Style.BackColor = Color.Orange;
                }
            }
        }

        //-----------------------------------------------------------------------------------------
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //-----------------------------------------------------------------------------------------
        private void btSend_Click(object sender, EventArgs e)
        {
            if( (dgvSequence.Rows.Count-1) > 0
                && dgvSequence.Rows.Count<2001 )
            {
                string[] sequence = new string[2000];
                bool error = false;
                int counter = 0;

                for( int i=0; i<dgvSequence.Rows.Count-1; i++ )
                {
                    DataGridViewRow row = dgvSequence.Rows[i];
                    row.Cells[0].Style.BackColor = SystemColors.Window;
                    row.Cells[1].Style.BackColor = SystemColors.Window;
                    counter++;

                    if ( row.Cells[1].Value != null
                        && ((string)row.Cells[1].Value).Length > 0 )
                    {
                        sequence[i] = ((string)row.Cells[1].Value).ToUpper();
                    }
                    else
                    {
                        row.Cells[0].Style.BackColor = SystemColors.Window;
                        row.Cells[1].Style.BackColor = Color.Red;
                        error = true;
                    }
                }

                if( error )
                {
                    //empty cells or wrong value
                    return;
                }

                if( sequence[counter-1] != "END" )
                {
                    sequence[counter] = "END";
                    counter++;
                }

                //OK
                Array.Resize( ref sequence, counter);
                dgvSequence.Tag = sequence;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if(dgvSequence.Rows.Count==1)
            {
                //error empty sequence 
            }
            else if(dgvSequence.Rows.Count >= 2001 )
            {
                //sequence to long
            }
        }

        #endregion
    }
}
