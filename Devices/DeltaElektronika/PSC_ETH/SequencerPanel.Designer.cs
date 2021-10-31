
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
            this.btTrigger = new System.Windows.Forms.Button();
            this.btContinue = new System.Windows.Forms.Button();
            this.btNextStep = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btPause = new System.Windows.Forms.Button();
            this.btPlay = new System.Windows.Forms.Button();
            this.tbSequenceStatus = new System.Windows.Forms.TextBox();
            this.dgvSequence = new System.Windows.Forms.DataGridView();
            this.colIdx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSequenceName = new System.Windows.Forms.TextBox();
            this.btDeleteSequence = new System.Windows.Forms.Button();
            this.scSequencer = new System.Windows.Forms.SplitContainer();
            this.btAddFile = new System.Windows.Forms.Button();
            this.btAddSequence = new System.Windows.Forms.Button();
            this.gbSequenceControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSequence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scSequencer)).BeginInit();
            this.scSequencer.Panel1.SuspendLayout();
            this.scSequencer.Panel2.SuspendLayout();
            this.scSequencer.SuspendLayout();
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
            this.lbCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCatalog.FormattingEnabled = true;
            this.lbCatalog.Location = new System.Drawing.Point(3, 32);
            this.lbCatalog.Name = "lbCatalog";
            this.lbCatalog.ScrollAlwaysVisible = true;
            this.lbCatalog.Size = new System.Drawing.Size(167, 394);
            this.lbCatalog.TabIndex = 18;
            this.lbCatalog.SelectedIndexChanged += new System.EventHandler(this.lbCatalog_SelectedIndexChanged);
            // 
            // btRefreshCatalog
            // 
            this.btRefreshCatalog.Location = new System.Drawing.Point(3, 3);
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
            this.gbSequenceControl.Controls.Add(this.btTrigger);
            this.gbSequenceControl.Controls.Add(this.btContinue);
            this.gbSequenceControl.Controls.Add(this.btNextStep);
            this.gbSequenceControl.Controls.Add(this.btSave);
            this.gbSequenceControl.Controls.Add(this.btEdit);
            this.gbSequenceControl.Controls.Add(this.btStop);
            this.gbSequenceControl.Controls.Add(this.btPause);
            this.gbSequenceControl.Controls.Add(this.btPlay);
            this.gbSequenceControl.Controls.Add(this.tbSequenceStatus);
            this.gbSequenceControl.Controls.Add(this.dgvSequence);
            this.gbSequenceControl.Controls.Add(this.tbSequenceName);
            this.gbSequenceControl.Controls.Add(this.btDeleteSequence);
            this.gbSequenceControl.Enabled = false;
            this.gbSequenceControl.Location = new System.Drawing.Point(3, 3);
            this.gbSequenceControl.Name = "gbSequenceControl";
            this.gbSequenceControl.Size = new System.Drawing.Size(499, 466);
            this.gbSequenceControl.TabIndex = 20;
            this.gbSequenceControl.TabStop = false;
            this.gbSequenceControl.Text = "Sequence Control";
            // 
            // btTrigger
            // 
            this.btTrigger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btTrigger.BackgroundImage = global::DeltaElektronika.Properties.Resources.trigger;
            this.btTrigger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTrigger.ForeColor = System.Drawing.SystemColors.Control;
            this.btTrigger.Location = new System.Drawing.Point(274, 430);
            this.btTrigger.Name = "btTrigger";
            this.btTrigger.Size = new System.Drawing.Size(30, 30);
            this.btTrigger.TabIndex = 32;
            this.btTrigger.UseVisualStyleBackColor = true;
            this.btTrigger.Click += new System.EventHandler(this.btTrigger_Click);
            // 
            // btContinue
            // 
            this.btContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btContinue.BackgroundImage = global::DeltaElektronika.Properties.Resources._continue;
            this.btContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btContinue.ForeColor = System.Drawing.SystemColors.Control;
            this.btContinue.Location = new System.Drawing.Point(114, 430);
            this.btContinue.Name = "btContinue";
            this.btContinue.Size = new System.Drawing.Size(30, 30);
            this.btContinue.TabIndex = 31;
            this.btContinue.UseVisualStyleBackColor = true;
            this.btContinue.Click += new System.EventHandler(this.btContinue_Click);
            // 
            // btNextStep
            // 
            this.btNextStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btNextStep.BackgroundImage = global::DeltaElektronika.Properties.Resources.next;
            this.btNextStep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btNextStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNextStep.ForeColor = System.Drawing.SystemColors.Control;
            this.btNextStep.Location = new System.Drawing.Point(42, 430);
            this.btNextStep.Name = "btNextStep";
            this.btNextStep.Size = new System.Drawing.Size(30, 30);
            this.btNextStep.TabIndex = 30;
            this.btNextStep.UseVisualStyleBackColor = true;
            this.btNextStep.Click += new System.EventHandler(this.btNextStep_Click);
            // 
            // btSave
            // 
            this.btSave.BackgroundImage = global::DeltaElektronika.Properties.Resources.save;
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btSave.Location = new System.Drawing.Point(190, 19);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(23, 23);
            this.btSave.TabIndex = 29;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackgroundImage = global::DeltaElektronika.Properties.Resources.edit;
            this.btEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.btEdit.Location = new System.Drawing.Point(161, 19);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(23, 23);
            this.btEdit.TabIndex = 28;
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btStop
            // 
            this.btStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btStop.BackgroundImage = global::DeltaElektronika.Properties.Resources.stop;
            this.btStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStop.ForeColor = System.Drawing.SystemColors.Control;
            this.btStop.Location = new System.Drawing.Point(150, 430);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(30, 30);
            this.btStop.TabIndex = 6;
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btPause
            // 
            this.btPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPause.BackgroundImage = global::DeltaElektronika.Properties.Resources.pause;
            this.btPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPause.ForeColor = System.Drawing.SystemColors.Control;
            this.btPause.Location = new System.Drawing.Point(78, 430);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(30, 30);
            this.btPause.TabIndex = 5;
            this.btPause.UseVisualStyleBackColor = true;
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // btPlay
            // 
            this.btPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPlay.BackgroundImage = global::DeltaElektronika.Properties.Resources.play;
            this.btPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlay.ForeColor = System.Drawing.SystemColors.Control;
            this.btPlay.Location = new System.Drawing.Point(6, 430);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(30, 30);
            this.btPlay.TabIndex = 4;
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // tbSequenceStatus
            // 
            this.tbSequenceStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSequenceStatus.Location = new System.Drawing.Point(186, 430);
            this.tbSequenceStatus.Name = "tbSequenceStatus";
            this.tbSequenceStatus.ReadOnly = true;
            this.tbSequenceStatus.Size = new System.Drawing.Size(82, 20);
            this.tbSequenceStatus.TabIndex = 3;
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
            this.dgvSequence.Location = new System.Drawing.Point(6, 48);
            this.dgvSequence.Name = "dgvSequence";
            this.dgvSequence.ReadOnly = true;
            this.dgvSequence.RowHeadersVisible = false;
            this.dgvSequence.Size = new System.Drawing.Size(487, 376);
            this.dgvSequence.TabIndex = 2;
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
            // tbSequenceName
            // 
            this.tbSequenceName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSequenceName.Location = new System.Drawing.Point(6, 19);
            this.tbSequenceName.Name = "tbSequenceName";
            this.tbSequenceName.ReadOnly = true;
            this.tbSequenceName.Size = new System.Drawing.Size(149, 23);
            this.tbSequenceName.TabIndex = 1;
            this.tbSequenceName.TextChanged += new System.EventHandler(this.tbSequenceName_TextChanged);
            // 
            // btDeleteSequence
            // 
            this.btDeleteSequence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteSequence.BackgroundImage = global::DeltaElektronika.Properties.Resources.remove;
            this.btDeleteSequence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDeleteSequence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteSequence.ForeColor = System.Drawing.SystemColors.Control;
            this.btDeleteSequence.Location = new System.Drawing.Point(463, 430);
            this.btDeleteSequence.Name = "btDeleteSequence";
            this.btDeleteSequence.Size = new System.Drawing.Size(30, 30);
            this.btDeleteSequence.TabIndex = 0;
            this.btDeleteSequence.UseVisualStyleBackColor = true;
            this.btDeleteSequence.Click += new System.EventHandler(this.btDeleteSequence_Click);
            // 
            // scSequencer
            // 
            this.scSequencer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scSequencer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scSequencer.Location = new System.Drawing.Point(3, 36);
            this.scSequencer.Name = "scSequencer";
            // 
            // scSequencer.Panel1
            // 
            this.scSequencer.Panel1.Controls.Add(this.btAddFile);
            this.scSequencer.Panel1.Controls.Add(this.btRefreshCatalog);
            this.scSequencer.Panel1.Controls.Add(this.btAddSequence);
            this.scSequencer.Panel1.Controls.Add(this.lbCatalog);
            // 
            // scSequencer.Panel2
            // 
            this.scSequencer.Panel2.Controls.Add(this.gbSequenceControl);
            this.scSequencer.Size = new System.Drawing.Size(682, 472);
            this.scSequencer.SplitterDistance = 173;
            this.scSequencer.TabIndex = 22;
            // 
            // btAddFile
            // 
            this.btAddFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAddFile.BackgroundImage = global::DeltaElektronika.Properties.Resources.folder;
            this.btAddFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddFile.ForeColor = System.Drawing.SystemColors.Control;
            this.btAddFile.Location = new System.Drawing.Point(39, 439);
            this.btAddFile.Name = "btAddFile";
            this.btAddFile.Size = new System.Drawing.Size(30, 30);
            this.btAddFile.TabIndex = 22;
            this.btAddFile.UseVisualStyleBackColor = true;
            this.btAddFile.Click += new System.EventHandler(this.btAddFile_Click);
            // 
            // btAddSequence
            // 
            this.btAddSequence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAddSequence.BackgroundImage = global::DeltaElektronika.Properties.Resources.plus;
            this.btAddSequence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAddSequence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddSequence.ForeColor = System.Drawing.SystemColors.Control;
            this.btAddSequence.Location = new System.Drawing.Point(3, 439);
            this.btAddSequence.Name = "btAddSequence";
            this.btAddSequence.Size = new System.Drawing.Size(30, 30);
            this.btAddSequence.TabIndex = 21;
            this.btAddSequence.UseVisualStyleBackColor = true;
            this.btAddSequence.Click += new System.EventHandler(this.btAddSequence_Click);
            // 
            // SequencerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scSequencer);
            this.Controls.Add(this.lbTitle);
            this.Name = "SequencerPanel";
            this.Size = new System.Drawing.Size(688, 511);
            this.gbSequenceControl.ResumeLayout(false);
            this.gbSequenceControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSequence)).EndInit();
            this.scSequencer.Panel1.ResumeLayout(false);
            this.scSequencer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSequencer)).EndInit();
            this.scSequencer.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer scSequencer;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btPause;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.TextBox tbSequenceStatus;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btAddFile;
        private System.Windows.Forms.Button btNextStep;
        private System.Windows.Forms.Button btContinue;
        private System.Windows.Forms.Button btTrigger;
    }
}
