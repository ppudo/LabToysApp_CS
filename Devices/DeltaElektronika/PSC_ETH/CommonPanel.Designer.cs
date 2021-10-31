
namespace DeltaElektronika.PSC_ETH
{
    partial class CommonPanel
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
            this.tbSetPud = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.tbRevisionCode = new System.Windows.Forms.TextBox();
            this.tbSerialNumber = new System.Windows.Forms.TextBox();
            this.lbRevisionCode = new System.Windows.Forms.Label();
            this.lbSerialNumber = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbManufacturer = new System.Windows.Forms.TextBox();
            this.lbManufacturer = new System.Windows.Forms.Label();
            this.btSetPud = new System.Windows.Forms.Button();
            this.btGetPud = new System.Windows.Forms.Button();
            this.lbUserData = new System.Windows.Forms.Label();
            this.lbRecallCalibration = new System.Windows.Forms.Label();
            this.btIDN = new System.Windows.Forms.Button();
            this.tbGetPud = new System.Windows.Forms.TextBox();
            this.btRecallCalibration = new System.Windows.Forms.Button();
            this.lbRestore = new System.Windows.Forms.Label();
            this.btRestore = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbIDN = new System.Windows.Forms.GroupBox();
            this.gbIDN.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSetPud
            // 
            this.tbSetPud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSetPud.Enabled = false;
            this.tbSetPud.Location = new System.Drawing.Point(84, 280);
            this.tbSetPud.MaxLength = 70;
            this.tbSetPud.Name = "tbSetPud";
            this.tbSetPud.Size = new System.Drawing.Size(392, 20);
            this.tbSetPud.TabIndex = 26;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(6, 100);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 9;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // tbRevisionCode
            // 
            this.tbRevisionCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRevisionCode.Location = new System.Drawing.Point(303, 97);
            this.tbRevisionCode.Name = "tbRevisionCode";
            this.tbRevisionCode.ReadOnly = true;
            this.tbRevisionCode.Size = new System.Drawing.Size(164, 20);
            this.tbRevisionCode.TabIndex = 8;
            this.tbRevisionCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSerialNumber
            // 
            this.tbSerialNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSerialNumber.Location = new System.Drawing.Point(303, 71);
            this.tbSerialNumber.Name = "tbSerialNumber";
            this.tbSerialNumber.ReadOnly = true;
            this.tbSerialNumber.Size = new System.Drawing.Size(164, 20);
            this.tbSerialNumber.TabIndex = 7;
            this.tbSerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbRevisionCode
            // 
            this.lbRevisionCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRevisionCode.Location = new System.Drawing.Point(147, 100);
            this.lbRevisionCode.Name = "lbRevisionCode";
            this.lbRevisionCode.Size = new System.Drawing.Size(150, 13);
            this.lbRevisionCode.TabIndex = 6;
            this.lbRevisionCode.Text = "Revision code:";
            this.lbRevisionCode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbSerialNumber
            // 
            this.lbSerialNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSerialNumber.Location = new System.Drawing.Point(147, 74);
            this.lbSerialNumber.Name = "lbSerialNumber";
            this.lbSerialNumber.Size = new System.Drawing.Size(150, 13);
            this.lbSerialNumber.TabIndex = 5;
            this.lbSerialNumber.Text = "Serial number:";
            this.lbSerialNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbModel
            // 
            this.lbModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbModel.Location = new System.Drawing.Point(147, 48);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(150, 13);
            this.lbModel.TabIndex = 4;
            this.lbModel.Text = "Model:";
            this.lbModel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbModel
            // 
            this.tbModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbModel.Location = new System.Drawing.Point(303, 45);
            this.tbModel.Name = "tbModel";
            this.tbModel.ReadOnly = true;
            this.tbModel.Size = new System.Drawing.Size(164, 20);
            this.tbModel.TabIndex = 3;
            this.tbModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbManufacturer
            // 
            this.tbManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbManufacturer.Location = new System.Drawing.Point(303, 19);
            this.tbManufacturer.Name = "tbManufacturer";
            this.tbManufacturer.ReadOnly = true;
            this.tbManufacturer.Size = new System.Drawing.Size(164, 20);
            this.tbManufacturer.TabIndex = 2;
            this.tbManufacturer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbManufacturer
            // 
            this.lbManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbManufacturer.Location = new System.Drawing.Point(147, 22);
            this.lbManufacturer.Name = "lbManufacturer";
            this.lbManufacturer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbManufacturer.Size = new System.Drawing.Size(150, 13);
            this.lbManufacturer.TabIndex = 1;
            this.lbManufacturer.Text = "Manufacturer:";
            this.lbManufacturer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btSetPud
            // 
            this.btSetPud.Enabled = false;
            this.btSetPud.Location = new System.Drawing.Point(3, 278);
            this.btSetPud.Name = "btSetPud";
            this.btSetPud.Size = new System.Drawing.Size(75, 23);
            this.btSetPud.TabIndex = 24;
            this.btSetPud.Text = "*PUD";
            this.btSetPud.UseVisualStyleBackColor = true;
            this.btSetPud.Click += new System.EventHandler(this.btSetPud_Click);
            // 
            // btGetPud
            // 
            this.btGetPud.Location = new System.Drawing.Point(3, 249);
            this.btGetPud.Name = "btGetPud";
            this.btGetPud.Size = new System.Drawing.Size(75, 23);
            this.btGetPud.TabIndex = 23;
            this.btGetPud.Text = "*PUD?";
            this.btGetPud.UseVisualStyleBackColor = true;
            this.btGetPud.Click += new System.EventHandler(this.btGetPud_Click);
            // 
            // lbUserData
            // 
            this.lbUserData.AutoSize = true;
            this.lbUserData.Location = new System.Drawing.Point(3, 233);
            this.lbUserData.Name = "lbUserData";
            this.lbUserData.Size = new System.Drawing.Size(103, 13);
            this.lbUserData.TabIndex = 22;
            this.lbUserData.Text = "Protected user data:";
            // 
            // lbRecallCalibration
            // 
            this.lbRecallCalibration.AutoSize = true;
            this.lbRecallCalibration.Location = new System.Drawing.Point(3, 204);
            this.lbRecallCalibration.Name = "lbRecallCalibration";
            this.lbRecallCalibration.Size = new System.Drawing.Size(91, 13);
            this.lbRecallCalibration.TabIndex = 21;
            this.lbRecallCalibration.Text = "Recall calibration:";
            // 
            // btIDN
            // 
            this.btIDN.Location = new System.Drawing.Point(6, 19);
            this.btIDN.Name = "btIDN";
            this.btIDN.Size = new System.Drawing.Size(75, 23);
            this.btIDN.TabIndex = 0;
            this.btIDN.Text = "*IDN?";
            this.btIDN.UseVisualStyleBackColor = true;
            this.btIDN.Click += new System.EventHandler(this.btIDN_Click);
            // 
            // tbGetPud
            // 
            this.tbGetPud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGetPud.Enabled = false;
            this.tbGetPud.Location = new System.Drawing.Point(84, 251);
            this.tbGetPud.Name = "tbGetPud";
            this.tbGetPud.ReadOnly = true;
            this.tbGetPud.Size = new System.Drawing.Size(392, 20);
            this.tbGetPud.TabIndex = 25;
            // 
            // btRecallCalibration
            // 
            this.btRecallCalibration.Enabled = false;
            this.btRecallCalibration.Location = new System.Drawing.Point(100, 199);
            this.btRecallCalibration.Name = "btRecallCalibration";
            this.btRecallCalibration.Size = new System.Drawing.Size(75, 23);
            this.btRecallCalibration.TabIndex = 20;
            this.btRecallCalibration.Text = "*RCL";
            this.btRecallCalibration.UseVisualStyleBackColor = true;
            this.btRecallCalibration.Click += new System.EventHandler(this.btRecallCalibration_Click);
            // 
            // lbRestore
            // 
            this.lbRestore.AutoSize = true;
            this.lbRestore.Location = new System.Drawing.Point(3, 175);
            this.lbRestore.Name = "lbRestore";
            this.lbRestore.Size = new System.Drawing.Size(80, 13);
            this.lbRestore.TabIndex = 19;
            this.lbRestore.Text = "Restore to def.:";
            // 
            // btRestore
            // 
            this.btRestore.Location = new System.Drawing.Point(100, 170);
            this.btRestore.Name = "btRestore";
            this.btRestore.Size = new System.Drawing.Size(75, 23);
            this.btRestore.TabIndex = 18;
            this.btRestore.Text = "*RST";
            this.btRestore.UseVisualStyleBackColor = true;
            this.btRestore.Click += new System.EventHandler(this.btRestore_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTitle.Location = new System.Drawing.Point(3, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(270, 33);
            this.lbTitle.TabIndex = 17;
            this.lbTitle.Text = "Common commands";
            // 
            // gbIDN
            // 
            this.gbIDN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbIDN.Controls.Add(this.btClear);
            this.gbIDN.Controls.Add(this.tbRevisionCode);
            this.gbIDN.Controls.Add(this.tbSerialNumber);
            this.gbIDN.Controls.Add(this.lbRevisionCode);
            this.gbIDN.Controls.Add(this.lbSerialNumber);
            this.gbIDN.Controls.Add(this.lbModel);
            this.gbIDN.Controls.Add(this.tbModel);
            this.gbIDN.Controls.Add(this.tbManufacturer);
            this.gbIDN.Controls.Add(this.lbManufacturer);
            this.gbIDN.Controls.Add(this.btIDN);
            this.gbIDN.Location = new System.Drawing.Point(3, 36);
            this.gbIDN.Name = "gbIDN";
            this.gbIDN.Size = new System.Drawing.Size(473, 128);
            this.gbIDN.TabIndex = 16;
            this.gbIDN.TabStop = false;
            this.gbIDN.Text = "Instrument ID";
            // 
            // CommonPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbSetPud);
            this.Controls.Add(this.btSetPud);
            this.Controls.Add(this.btGetPud);
            this.Controls.Add(this.lbUserData);
            this.Controls.Add(this.lbRecallCalibration);
            this.Controls.Add(this.tbGetPud);
            this.Controls.Add(this.btRecallCalibration);
            this.Controls.Add(this.lbRestore);
            this.Controls.Add(this.btRestore);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.gbIDN);
            this.Name = "CommonPanel";
            this.Size = new System.Drawing.Size(479, 325);
            this.gbIDN.ResumeLayout(false);
            this.gbIDN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSetPud;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TextBox tbRevisionCode;
        private System.Windows.Forms.TextBox tbSerialNumber;
        private System.Windows.Forms.Label lbRevisionCode;
        private System.Windows.Forms.Label lbSerialNumber;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbManufacturer;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.Button btSetPud;
        private System.Windows.Forms.Button btGetPud;
        private System.Windows.Forms.Label lbUserData;
        private System.Windows.Forms.Label lbRecallCalibration;
        private System.Windows.Forms.Button btIDN;
        private System.Windows.Forms.TextBox tbGetPud;
        private System.Windows.Forms.Button btRecallCalibration;
        private System.Windows.Forms.Label lbRestore;
        private System.Windows.Forms.Button btRestore;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox gbIDN;
    }
}
