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
using System.IO;

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
            LANGUAGE = lang;
            this.device = device;

            //set language version and disable and enable some controls depends on options
            SetLanguage(LANGUAGE);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
        private LabToys.DeltaElektronika.PSC_ETH device = null;
        private string LANGUAGE = "";

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
            LANGUAGE = lang;
            SetLanguage(lang);
        }

        //-----------------------------------------------------------------------------------------
        public void DisplayDeviceStatus()
        {
            if (device.Status.SelectedSequence.Length > 0)
            {
                if (tbSequenceName.Text != device.Status.SelectedSequence)
                {
                    SetTextControl(tbSequenceName, device.Status.SelectedSequence);
                }

                if (device.Status.SequenceStatus.State != LabToys.DeltaElektronika.PSC_ETH.SequenceState.ERROR )
                {
                    switch (device.Status.SequenceStatus.State)
                    {
                        case LabToys.DeltaElektronika.PSC_ETH.SequenceState.STOP:
                            SetTextControl(tbSequenceStatus, "STOP" );
                            break;
                        case LabToys.DeltaElektronika.PSC_ETH.SequenceState.RUN:
                            SetTextControl(tbSequenceStatus, "RUN, " + device.Status.SequenceStatus.Idx.ToString() );
                            break;
                        case LabToys.DeltaElektronika.PSC_ETH.SequenceState.PAUSE:
                            SetTextControl(tbSequenceStatus, "PAUSE, " + device.Status.SequenceStatus.Idx.ToString());
                            break;
                        default:
                            SetTextControl(tbSequenceStatus, "" );
                            break;
                    }
                }
            }
        }

        #endregion

        #region ACTION_ITEMS
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
                    dgvSequence.Rows.Clear();
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

                tbSequenceStatus.Text = "";
                dgvSequence.Rows.Clear();
                string[] sequence = device.GetCompleteSequence();

                if ( sequence.Length == 0 )
                {
                    Cursor.Current = Cursors.Default;
                    return;
                }

                dgvSequence.Tag = sequence;
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

        //-----------------------------------------------------------------------------------------
        private void btNextStep_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!device.NextStep())
            {

            }
            Cursor.Current = Cursors.Default;
        }

        //-----------------------------------------------------------------------------------------
        private void btContinue_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!device.ContinueSequence())
            {

            }
            Cursor.Current = Cursors.Default;
        }

        //-----------------------------------------------------------------------------------------
        private void btTrigger_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!device.TriggerStep())
            {

            }
            Cursor.Current = Cursors.Default;
        }

        //-----------------------------------------------------------------------------------------
        private void btSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.FileName = tbSequenceName.Text + ".txt";
            dialog.Filter = "Text files (*.txt) |*.txt|All files (*.*)|*.*";
            if( dialog.ShowDialog() == DialogResult.OK )
            {
                //create full data to save
                StringBuilder builder = new StringBuilder(tbSequenceName.Text + Environment.NewLine);

                string[] sequence = (string[])dgvSequence.Tag;
                for( int i=0; i<sequence.Length; i++ )
                {
                    builder.AppendLine( (i+1).ToString() + " " + sequence[i]);
                }

                //save file
                Stream file = dialog.OpenFile();
                file.Write(Encoding.ASCII.GetBytes(builder.ToString()), 0, builder.Length);
                file.Close();
            }
        }

        //-----------------------------------------------------------------------------------------
        private void btAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.Filter = "Text files (*.txt) |*.txt|All files (*.*)|*.*";
            if( dialog.ShowDialog() == DialogResult.OK )
            {
                Cursor.Current = Cursors.WaitCursor;

                //prepare stream and read name of sequence
                StreamReader file = new StreamReader(dialog.OpenFile());
                string[] sequence = new string[2000];
                string name = file.ReadLine();
                int count = 0;

                //read sequence step
                while( !file.EndOfStream )
                {
                    string line = file.ReadLine();
                    int idx = int.Parse(line.Substring(0, line.IndexOf(' ')));
                    sequence[idx - 1] = line.Substring(line.IndexOf(' ') + 1);
                    count++;
                }

                file.Close();
                Array.Resize(ref sequence, count);

                if( !device.SendSequence( name, sequence ) )
                {
                    Cursor.Current = Cursors.Default;
                }

                tbSequenceName.Text = name;
            }
        }

        //-----------------------------------------------------------------------------------------
        private void btAddSequence_Click(object sender, EventArgs e)
        {
            EditSequenceForm form = new EditSequenceForm(LANGUAGE);
            if (form.ShowDialog() == DialogResult.OK )
            {
                Cursor.Current = Cursors.WaitCursor;

                if (!device.SendSequence(form.SequenceName, form.SequenceSteps))
                {
                    Cursor.Current = Cursors.Default;
                }

                tbSequenceName.Text = form.SequenceName;
            }
        }

        //-----------------------------------------------------------------------------------------
        private void btEdit_Click(object sender, EventArgs e)
        {
            EditSequenceForm form = new EditSequenceForm(LANGUAGE, tbSequenceName.Text, (string[])dgvSequence.Tag);
            if (form.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                tbSequenceName.Text = "";

                if ( !device.DeleteSelectedSequence() )
                {
                    Cursor.Current = Cursors.Default;
                }

                if (!device.SendSequence(form.SequenceName, form.SequenceSteps))
                {
                    Cursor.Current = Cursors.Default;
                }

                tbSequenceName.Text = form.SequenceName;
            }
        }
        #endregion

        #region DELEGATES
        //-------------------------------------------------------------------------------------------------------------------------------------------
        //  DDDD  EEEEE L     EEEEE  GGG    A   TTTTT EEEEE  SSS
        //  D   D E     L     E     G      A A    T   E     S
        //  D   D EEE   L     EEE   G  GG A   A   T   EEE    SSS
        //  D   D E     L     E     G   G AAAAA   T   E         S
        //  DDDD  EEEEE LLLLL EEEEE  GGG  A   A   T   EEEEE  SSS
        //

        private delegate void SetTextControlDelegate(Control control, string text);

        private void SetTextControl(Control control, string text)
        {
            if (control.InvokeRequired)
            {
                SetTextControlDelegate d = new SetTextControlDelegate(SetTextControl);
                this.Invoke(d, new object[] { control, text });
            }
            else
            {
                control.Text = text;
            }
        }
        #endregion
    }
}
