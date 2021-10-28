
namespace Rigol.DS1000Z
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.gbLan = new System.Windows.Forms.GroupBox();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.lbPort = new System.Windows.Forms.Label();
            this.tbIPaddress = new System.Windows.Forms.TextBox();
            this.lbIPaddress = new System.Windows.Forms.Label();
            this.chbLan = new System.Windows.Forms.CheckBox();
            this.gbLan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(87, 12);
            this.tbName.MaxLength = 32;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(118, 20);
            this.tbName.TabIndex = 7;
            this.tbName.Text = "Rigol DS1000Z";
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 15);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(38, 13);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Name:";
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(12, 158);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.Location = new System.Drawing.Point(130, 158);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // gbLan
            // 
            this.gbLan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLan.Controls.Add(this.nudPort);
            this.gbLan.Controls.Add(this.lbPort);
            this.gbLan.Controls.Add(this.tbIPaddress);
            this.gbLan.Controls.Add(this.lbIPaddress);
            this.gbLan.Location = new System.Drawing.Point(12, 61);
            this.gbLan.Name = "gbLan";
            this.gbLan.Size = new System.Drawing.Size(193, 78);
            this.gbLan.TabIndex = 11;
            this.gbLan.TabStop = false;
            this.gbLan.Text = "LAN";
            // 
            // nudPort
            // 
            this.nudPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPort.Location = new System.Drawing.Point(71, 45);
            this.nudPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(116, 20);
            this.nudPort.TabIndex = 3;
            this.nudPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPort.Value = new decimal(new int[] {
            5555,
            0,
            0,
            0});
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(6, 47);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(29, 13);
            this.lbPort.TabIndex = 2;
            this.lbPort.Text = "Port:";
            // 
            // tbIPaddress
            // 
            this.tbIPaddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIPaddress.Location = new System.Drawing.Point(71, 19);
            this.tbIPaddress.Name = "tbIPaddress";
            this.tbIPaddress.Size = new System.Drawing.Size(116, 20);
            this.tbIPaddress.TabIndex = 1;
            this.tbIPaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbIPaddress
            // 
            this.lbIPaddress.AutoSize = true;
            this.lbIPaddress.Location = new System.Drawing.Point(6, 22);
            this.lbIPaddress.Name = "lbIPaddress";
            this.lbIPaddress.Size = new System.Drawing.Size(60, 13);
            this.lbIPaddress.TabIndex = 0;
            this.lbIPaddress.Text = "IP address:";
            // 
            // chbLan
            // 
            this.chbLan.AutoSize = true;
            this.chbLan.Checked = true;
            this.chbLan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLan.Enabled = false;
            this.chbLan.Location = new System.Drawing.Point(12, 38);
            this.chbLan.Name = "chbLan";
            this.chbLan.Size = new System.Drawing.Size(47, 17);
            this.chbLan.TabIndex = 10;
            this.chbLan.Text = "LAN";
            this.chbLan.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            this.AcceptButton = this.btAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(217, 193);
            this.Controls.Add(this.gbLan);
            this.Controls.Add(this.chbLan);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add DS1000Z";
            this.gbLan.ResumeLayout(false);
            this.gbLan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.GroupBox gbLan;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox tbIPaddress;
        private System.Windows.Forms.Label lbIPaddress;
        private System.Windows.Forms.CheckBox chbLan;
    }
}