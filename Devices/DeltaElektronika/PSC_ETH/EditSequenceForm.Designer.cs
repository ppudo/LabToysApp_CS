
namespace DeltaElektronika.PSC_ETH
{
    partial class EditSequenceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSequenceForm));
            this.dgvSequence = new System.Windows.Forms.DataGridView();
            this.colIdx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSequenceName = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btDeleteRow = new System.Windows.Forms.Button();
            this.btAddRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSequence)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSequence
            // 
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
            this.dgvSequence.Location = new System.Drawing.Point(12, 41);
            this.dgvSequence.Name = "dgvSequence";
            this.dgvSequence.Size = new System.Drawing.Size(370, 572);
            this.dgvSequence.TabIndex = 3;
            this.dgvSequence.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvSequence_CellBeginEdit);
            this.dgvSequence.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvSequence_UserAddedRow);
            this.dgvSequence.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvSequence_UserDeletedRow);
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
            this.colStep.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colStep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colStep.Width = 200;
            // 
            // tbSequenceName
            // 
            this.tbSequenceName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSequenceName.Location = new System.Drawing.Point(12, 12);
            this.tbSequenceName.MaxLength = 16;
            this.tbSequenceName.Name = "tbSequenceName";
            this.tbSequenceName.Size = new System.Drawing.Size(149, 23);
            this.tbSequenceName.TabIndex = 4;
            this.tbSequenceName.Text = "New_sequence";
            // 
            // btSend
            // 
            this.btSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSend.Location = new System.Drawing.Point(469, 590);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 5;
            this.btSend.Text = "Send...";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.Location = new System.Drawing.Point(388, 590);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btDeleteRow
            // 
            this.btDeleteRow.BackgroundImage = global::DeltaElektronika.Properties.Resources.minus_red;
            this.btDeleteRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteRow.ForeColor = System.Drawing.SystemColors.Control;
            this.btDeleteRow.Location = new System.Drawing.Point(388, 77);
            this.btDeleteRow.Name = "btDeleteRow";
            this.btDeleteRow.Size = new System.Drawing.Size(30, 30);
            this.btDeleteRow.TabIndex = 32;
            this.btDeleteRow.UseVisualStyleBackColor = true;
            this.btDeleteRow.Click += new System.EventHandler(this.btDeleteRow_Click);
            // 
            // btAddRow
            // 
            this.btAddRow.BackgroundImage = global::DeltaElektronika.Properties.Resources.plus_green;
            this.btAddRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddRow.ForeColor = System.Drawing.SystemColors.Control;
            this.btAddRow.Location = new System.Drawing.Point(388, 41);
            this.btAddRow.Name = "btAddRow";
            this.btAddRow.Size = new System.Drawing.Size(30, 30);
            this.btAddRow.TabIndex = 31;
            this.btAddRow.UseVisualStyleBackColor = true;
            this.btAddRow.Click += new System.EventHandler(this.btAddRow_Click);
            // 
            // EditSequenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 625);
            this.Controls.Add(this.btDeleteRow);
            this.Controls.Add(this.btAddRow);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.tbSequenceName);
            this.Controls.Add(this.dgvSequence);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditSequenceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit sequence";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSequence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSequence;
        private System.Windows.Forms.TextBox tbSequenceName;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdx;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStep;
        private System.Windows.Forms.Button btDeleteRow;
        private System.Windows.Forms.Button btAddRow;
    }
}