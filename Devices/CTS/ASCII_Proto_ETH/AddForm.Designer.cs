
namespace CTS.ASCII_Proto_ETH
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
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.lbPort = new System.Windows.Forms.Label();
            this.tbIPaddress = new System.Windows.Forms.TextBox();
            this.lbIPaddress = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.SuspendLayout();
            // 
            // nudPort
            // 
            this.nudPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPort.Location = new System.Drawing.Point(90, 64);
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
            1080,
            0,
            0,
            0});
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(12, 66);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(29, 13);
            this.lbPort.TabIndex = 2;
            this.lbPort.Text = "Port:";
            // 
            // tbIPaddress
            // 
            this.tbIPaddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIPaddress.Location = new System.Drawing.Point(90, 38);
            this.tbIPaddress.Name = "tbIPaddress";
            this.tbIPaddress.Size = new System.Drawing.Size(116, 20);
            this.tbIPaddress.TabIndex = 1;
            this.tbIPaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbIPaddress
            // 
            this.lbIPaddress.AutoSize = true;
            this.lbIPaddress.Location = new System.Drawing.Point(12, 41);
            this.lbIPaddress.Name = "lbIPaddress";
            this.lbIPaddress.Size = new System.Drawing.Size(60, 13);
            this.lbIPaddress.TabIndex = 0;
            this.lbIPaddress.Text = "IP address:";
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(12, 107);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 15;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.Location = new System.Drawing.Point(131, 107);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 14;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(90, 12);
            this.tbName.MaxLength = 32;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(116, 20);
            this.tbName.TabIndex = 13;
            this.tbName.Text = "ASCII-Proto-ETH";
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 15);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(38, 13);
            this.lbName.TabIndex = 12;
            this.lbName.Text = "Name:";
            // 
            // AddForm
            // 
            this.AcceptButton = this.btAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(218, 142);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.nudPort);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.lbIPaddress);
            this.Controls.Add(this.tbIPaddress);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add ASCII Proto ETH";
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox tbIPaddress;
        private System.Windows.Forms.Label lbIPaddress;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
    }
}