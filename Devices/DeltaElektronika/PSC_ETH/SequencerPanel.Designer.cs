
namespace DeltaElektronika.PSC_ETH
{
    partial class SequencerPanel
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbCatalog = new System.Windows.Forms.ListBox();
            this.btRefreshCatalog = new System.Windows.Forms.Button();
            this.gbSequenceControl = new System.Windows.Forms.GroupBox();
            this.dgvSequence = new System.Windows.Forms.DataGridView();
            this.tbSequenceName = new System.Windows.Forms.TextBox();
            this.btDeleteSequence = new System.Windows.Forms.Button();
            this.btAddSequence = new System.Windows.Forms.Button();
            this.colIdx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSequenceControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSequence)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTitle.Location = new System.Drawing.Point(3, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(168, 33);
            this.lbTitle.TabIndex = 17;
            this.lbTitle.Text = "Sequencer";
            // 
            // lbCatalog
            // 
            this.lbCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCatalog.FormattingEnabled = true;
            this.lbCatalog.Location = new System.Drawing.Point(3, 65);
            this.lbCatalog.Name = "lbCatalog";
            this.lbCatalog.ScrollAlwaysVisible = true;
            this.lbCatalog.Size = new System.Drawing.Size(142, 251);
            this.lbCatalog.TabIndex = 18;
            this.lbCatalog.SelectedIndexChanged += new System.EventHandler(this.lbCatalog_SelectedIndexChanged);
            // 
            // btRefreshCatalog
            // 
            this.btRefreshCatalog.Location = new System.Drawing.Point(3, 36);
            this.btRefreshCatalog.Name = "btRefreshCatalog";
            this.btRefreshCatalog.Size = new System.Drawing.Size(104, 23);
            this.btRefreshCatalog.TabIndex = 19;
            this.btRefreshCatalog.Text = "Refresh catalog";
            this.btRefreshCatalog.UseVisualStyleBackColor = true;
            this.btRefreshCatalog.Click += new System.EventHandler(this.btRefreshCatalog_Click);
            // 
            // gbSequenceControl
            // 
            this.gbSequenceControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSequenceControl.Controls.Add(this.dgvSequence);
            this.gbSequenceControl.Controls.Add(this.tbSequenceName);
            this.gbSequenceControl.Controls.Add(this.btDeleteSequence);
            this.gbSequenceControl.Enabled = false;
            this.gbSequenceControl.Location = new System.Drawing.Point(151, 36);
            this.gbSequenceControl.Name = "gbSequenceControl";
            this.gbSequenceControl.Size = new System.Drawing.Size(312, 324);
            this.gbSequenceControl.TabIndex = 20;
            this.gbSequenceControl.TabStop = false;
            this.gbSequenceControl.Text = "Sequence Control";
            // 
            // dgvSequence
            // 
            this.dgvSequence.AllowUserToAddRows = false;
            this.dgvSequence.AllowUserToDeleteRows = false;
            this.dgvSequence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSequence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSequence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSequence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdx,
            this.colStep});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSequence.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSequence.Location = new System.Drawing.Point(6, 45);
            this.dgvSequence.Name = "dgvSequence";
            this.dgvSequence.ReadOnly = true;
            this.dgvSequence.RowHeadersVisible = false;
            this.dgvSequence.Size = new System.Drawing.Size(300, 237);
            this.dgvSequence.TabIndex = 2;
            // 
            // tbSequenceName
            // 
            this.tbSequenceName.Location = new System.Drawing.Point(6, 19);
            this.tbSequenceName.Name = "tbSequenceName";
            this.tbSequenceName.ReadOnly = true;
            this.tbSequenceName.Size = new System.Drawing.Size(149, 20);
            this.tbSequenceName.TabIndex = 1;
            this.tbSequenceName.TextChanged += new System.EventHandler(this.tbSequenceName_TextChanged);
            // 
            // btDeleteSequence
            // 
            this.btDeleteSequence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteSequence.Location = new System.Drawing.Point(276, 288);
            this.btDeleteSequence.Name = "btDeleteSequence";
            this.btDeleteSequence.Size = new System.Drawing.Size(30, 30);
            this.btDeleteSequence.TabIndex = 0;
            this.btDeleteSequence.UseVisualStyleBackColor = true;
            this.btDeleteSequence.Click += new System.EventHandler(this.btDeleteSequence_Click);
            // 
            // btAddSequence
            // 
            this.btAddSequence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAddSequence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddSequence.Location = new System.Drawing.Point(3, 330);
            this.btAddSequence.Name = "btAddSequence";
            this.btAddSequence.Size = new System.Drawing.Size(30, 30);
            this.btAddSequence.TabIndex = 21;
            this.btAddSequence.UseVisualStyleBackColor = true;
            // 
            // colIdx
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colIdx.DefaultCellStyle = dataGridViewCellStyle2;
            this.colIdx.Frozen = true;
            this.colIdx.HeaderText = "Idx";
            this.colIdx.MinimumWidth = 30;
            this.colIdx.Name = "colIdx";
            this.colIdx.ReadOnly = true;
            this.colIdx.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colIdx.Width = 40;
            // 
            // colStep
            // 
            this.colStep.Frozen = true;
            this.colStep.HeaderText = "Step";
            this.colStep.MinimumWidth = 50;
            this.colStep.Name = "colStep";
            this.colStep.ReadOnly = true;
            this.colStep.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colStep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colStep.Width = 200;
            // 
            // SequencerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btAddSequence);
            this.Controls.Add(this.gbSequenceControl);
            this.Controls.Add(this.btRefreshCatalog);
            this.Controls.Add(this.lbCatalog);
            this.Controls.Add(this.lbTitle);
            this.Name = "SequencerPanel";
            this.Size = new System.Drawing.Size(466, 363);
            this.gbSequenceControl.ResumeLayout(false);
            this.gbSequenceControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSequence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ListBox lbCatalog;
        private System.Windows.Forms.Button btRefreshCatalog;
        private System.Windows.Forms.GroupBox gbSequenceControl;
        private System.Windows.Forms.Button btDeleteSequence;
        private System.Windows.Forms.TextBox tbSequenceName;
        private System.Windows.Forms.Button btAddSequence;
        private System.Windows.Forms.DataGridView dgvSequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdx;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStep;
    }
}
