
namespace DS1000Z
{
    partial class HomePanel
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.btSingle = new System.Windows.Forms.Button();
            this.btForce = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btRun = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btAuto = new System.Windows.Forms.Button();
            this.gbScreen = new System.Windows.Forms.GroupBox();
            this.nudScreenNo = new System.Windows.Forms.NumericUpDown();
            this.lbScreenNo = new System.Windows.Forms.Label();
            this.cbScreenFormat = new System.Windows.Forms.ComboBox();
            this.tbScreenName = new System.Windows.Forms.TextBox();
            this.lbScreenName = new System.Windows.Forms.Label();
            this.btScreenBrowse = new System.Windows.Forms.Button();
            this.lbScreenFolder = new System.Windows.Forms.Label();
            this.tbScreenFolder = new System.Windows.Forms.TextBox();
            this.btSaveScreen = new System.Windows.Forms.Button();
            this.gbScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScreenNo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTitle.Location = new System.Drawing.Point(3, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(83, 33);
            this.lbTitle.TabIndex = 16;
            this.lbTitle.Text = "Main";
            // 
            // btSingle
            // 
            this.btSingle.Location = new System.Drawing.Point(327, 36);
            this.btSingle.Name = "btSingle";
            this.btSingle.Size = new System.Drawing.Size(75, 23);
            this.btSingle.TabIndex = 22;
            this.btSingle.Text = "SINGLE";
            this.btSingle.UseVisualStyleBackColor = true;
            this.btSingle.Click += new System.EventHandler(this.btSingle_Click);
            // 
            // btForce
            // 
            this.btForce.Location = new System.Drawing.Point(327, 65);
            this.btForce.Name = "btForce";
            this.btForce.Size = new System.Drawing.Size(75, 23);
            this.btForce.TabIndex = 21;
            this.btForce.Text = "FORCE";
            this.btForce.UseVisualStyleBackColor = true;
            this.btForce.Click += new System.EventHandler(this.btForce_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(246, 36);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 20;
            this.btStop.Text = "STOP";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(165, 36);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(75, 23);
            this.btRun.TabIndex = 19;
            this.btRun.Text = "RUN";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(84, 36);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 18;
            this.btClear.Text = "CLEAR";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btAuto
            // 
            this.btAuto.Location = new System.Drawing.Point(3, 36);
            this.btAuto.Name = "btAuto";
            this.btAuto.Size = new System.Drawing.Size(75, 23);
            this.btAuto.TabIndex = 17;
            this.btAuto.Text = "AUTO";
            this.btAuto.UseVisualStyleBackColor = true;
            this.btAuto.Click += new System.EventHandler(this.btAuto_Click);
            // 
            // gbScreen
            // 
            this.gbScreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbScreen.Controls.Add(this.nudScreenNo);
            this.gbScreen.Controls.Add(this.lbScreenNo);
            this.gbScreen.Controls.Add(this.cbScreenFormat);
            this.gbScreen.Controls.Add(this.tbScreenName);
            this.gbScreen.Controls.Add(this.lbScreenName);
            this.gbScreen.Controls.Add(this.btScreenBrowse);
            this.gbScreen.Controls.Add(this.lbScreenFolder);
            this.gbScreen.Controls.Add(this.tbScreenFolder);
            this.gbScreen.Controls.Add(this.btSaveScreen);
            this.gbScreen.Location = new System.Drawing.Point(3, 94);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Size = new System.Drawing.Size(405, 82);
            this.gbScreen.TabIndex = 23;
            this.gbScreen.TabStop = false;
            this.gbScreen.Text = "Screenshot";
            // 
            // nudScreenNo
            // 
            this.nudScreenNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudScreenNo.Location = new System.Drawing.Point(262, 49);
            this.nudScreenNo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudScreenNo.Name = "nudScreenNo";
            this.nudScreenNo.ReadOnly = true;
            this.nudScreenNo.Size = new System.Drawing.Size(56, 20);
            this.nudScreenNo.TabIndex = 23;
            this.nudScreenNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbScreenNo
            // 
            this.lbScreenNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbScreenNo.AutoSize = true;
            this.lbScreenNo.Location = new System.Drawing.Point(232, 51);
            this.lbScreenNo.Name = "lbScreenNo";
            this.lbScreenNo.Size = new System.Drawing.Size(24, 13);
            this.lbScreenNo.TabIndex = 22;
            this.lbScreenNo.Text = "No.";
            // 
            // cbScreenFormat
            // 
            this.cbScreenFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbScreenFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScreenFormat.FormattingEnabled = true;
            this.cbScreenFormat.Location = new System.Drawing.Point(162, 47);
            this.cbScreenFormat.Name = "cbScreenFormat";
            this.cbScreenFormat.Size = new System.Drawing.Size(64, 21);
            this.cbScreenFormat.TabIndex = 20;
            // 
            // tbScreenName
            // 
            this.tbScreenName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbScreenName.Location = new System.Drawing.Point(68, 48);
            this.tbScreenName.Name = "tbScreenName";
            this.tbScreenName.Size = new System.Drawing.Size(88, 20);
            this.tbScreenName.TabIndex = 19;
            this.tbScreenName.Text = "Screen";
            this.tbScreenName.TextChanged += new System.EventHandler(this.tbScreen_TextChanged);
            // 
            // lbScreenName
            // 
            this.lbScreenName.AutoSize = true;
            this.lbScreenName.Location = new System.Drawing.Point(6, 51);
            this.lbScreenName.Name = "lbScreenName";
            this.lbScreenName.Size = new System.Drawing.Size(38, 13);
            this.lbScreenName.TabIndex = 18;
            this.lbScreenName.Text = "Name:";
            // 
            // btScreenBrowse
            // 
            this.btScreenBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btScreenBrowse.Location = new System.Drawing.Point(324, 17);
            this.btScreenBrowse.Name = "btScreenBrowse";
            this.btScreenBrowse.Size = new System.Drawing.Size(75, 23);
            this.btScreenBrowse.TabIndex = 17;
            this.btScreenBrowse.Text = "Browse...";
            this.btScreenBrowse.UseVisualStyleBackColor = true;
            this.btScreenBrowse.Click += new System.EventHandler(this.btScreenBrowse_Click);
            // 
            // lbScreenFolder
            // 
            this.lbScreenFolder.AutoSize = true;
            this.lbScreenFolder.Location = new System.Drawing.Point(6, 22);
            this.lbScreenFolder.Name = "lbScreenFolder";
            this.lbScreenFolder.Size = new System.Drawing.Size(39, 13);
            this.lbScreenFolder.TabIndex = 16;
            this.lbScreenFolder.Text = "Folder:";
            // 
            // tbScreenFolder
            // 
            this.tbScreenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbScreenFolder.Location = new System.Drawing.Point(68, 19);
            this.tbScreenFolder.Name = "tbScreenFolder";
            this.tbScreenFolder.ReadOnly = true;
            this.tbScreenFolder.Size = new System.Drawing.Size(250, 20);
            this.tbScreenFolder.TabIndex = 15;
            // 
            // btSaveScreen
            // 
            this.btSaveScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSaveScreen.Location = new System.Drawing.Point(324, 46);
            this.btSaveScreen.Name = "btSaveScreen";
            this.btSaveScreen.Size = new System.Drawing.Size(75, 23);
            this.btSaveScreen.TabIndex = 14;
            this.btSaveScreen.Text = "Save screen";
            this.btSaveScreen.UseVisualStyleBackColor = true;
            this.btSaveScreen.Click += new System.EventHandler(this.btSaveScreen_Click);
            // 
            // HomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbScreen);
            this.Controls.Add(this.btSingle);
            this.Controls.Add(this.btForce);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btAuto);
            this.Controls.Add(this.lbTitle);
            this.Name = "HomePanel";
            this.Size = new System.Drawing.Size(411, 264);
            this.gbScreen.ResumeLayout(false);
            this.gbScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScreenNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btSingle;
        private System.Windows.Forms.Button btForce;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btAuto;
        private System.Windows.Forms.GroupBox gbScreen;
        private System.Windows.Forms.NumericUpDown nudScreenNo;
        private System.Windows.Forms.Label lbScreenNo;
        private System.Windows.Forms.ComboBox cbScreenFormat;
        private System.Windows.Forms.TextBox tbScreenName;
        private System.Windows.Forms.Label lbScreenName;
        private System.Windows.Forms.Button btScreenBrowse;
        private System.Windows.Forms.Label lbScreenFolder;
        private System.Windows.Forms.TextBox tbScreenFolder;
        private System.Windows.Forms.Button btSaveScreen;
    }
}
