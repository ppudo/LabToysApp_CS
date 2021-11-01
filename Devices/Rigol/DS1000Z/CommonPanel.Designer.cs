
namespace Rigol.DS1000Z
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
            this.tbSelfTest = new System.Windows.Forms.TextBox();
            this.lbSelfTest = new System.Windows.Forms.Label();
            this.lbRestore = new System.Windows.Forms.Label();
            this.btRestore = new System.Windows.Forms.Button();
            this.btSelfTest = new System.Windows.Forms.Button();
            this.lbClearStatus = new System.Windows.Forms.Label();
            this.btClearStatus = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbIDN = new System.Windows.Forms.GroupBox();
            this.btClear = new System.Windows.Forms.Button();
            this.tbRevisionCode = new System.Windows.Forms.TextBox();
            this.tbSerialNumber = new System.Windows.Forms.TextBox();
            this.lbRevisionCode = new System.Windows.Forms.Label();
            this.lbSerialNumber = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbManufacturer = new System.Windows.Forms.TextBox();
            this.lbManufacturer = new System.Windows.Forms.Label();
            this.btIDN = new System.Windows.Forms.Button();
            this.gbIDN.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSelfTest
            // 
            this.tbSelfTest.Location = new System.Drawing.Point(170, 230);
            this.tbSelfTest.Name = "tbSelfTest";
            this.tbSelfTest.ReadOnly = true;
            this.tbSelfTest.Size = new System.Drawing.Size(81, 20);
            this.tbSelfTest.TabIndex = 17;
            // 
            // lbSelfTest
            // 
            this.lbSelfTest.AutoSize = true;
            this.lbSelfTest.Location = new System.Drawing.Point(3, 233);
            this.lbSelfTest.Name = "lbSelfTest";
            this.lbSelfTest.Size = new System.Drawing.Size(48, 13);
            this.lbSelfTest.TabIndex = 16;
            this.lbSelfTest.Text = "Self test:";
            // 
            // lbRestore
            // 
            this.lbRestore.AutoSize = true;
            this.lbRestore.Location = new System.Drawing.Point(3, 204);
            this.lbRestore.Name = "lbRestore";
            this.lbRestore.Size = new System.Drawing.Size(80, 13);
            this.lbRestore.TabIndex = 15;
            this.lbRestore.Text = "Restore to def.:";
            // 
            // btRestore
            // 
            this.btRestore.Location = new System.Drawing.Point(89, 199);
            this.btRestore.Name = "btRestore";
            this.btRestore.Size = new System.Drawing.Size(75, 23);
            this.btRestore.TabIndex = 14;
            this.btRestore.Text = "*RST";
            this.btRestore.UseVisualStyleBackColor = true;
            this.btRestore.Click += new System.EventHandler(this.btRestore_Click);
            // 
            // btSelfTest
            // 
            this.btSelfTest.Location = new System.Drawing.Point(89, 228);
            this.btSelfTest.Name = "btSelfTest";
            this.btSelfTest.Size = new System.Drawing.Size(75, 23);
            this.btSelfTest.TabIndex = 13;
            this.btSelfTest.Text = "*TST?";
            this.btSelfTest.UseVisualStyleBackColor = true;
            this.btSelfTest.Click += new System.EventHandler(this.btSelfTest_Click);
            // 
            // lbClearStatus
            // 
            this.lbClearStatus.AutoSize = true;
            this.lbClearStatus.Location = new System.Drawing.Point(3, 175);
            this.lbClearStatus.Name = "lbClearStatus";
            this.lbClearStatus.Size = new System.Drawing.Size(65, 13);
            this.lbClearStatus.TabIndex = 12;
            this.lbClearStatus.Text = "Clear status:";
            // 
            // btClearStatus
            // 
            this.btClearStatus.Location = new System.Drawing.Point(89, 170);
            this.btClearStatus.Name = "btClearStatus";
            this.btClearStatus.Size = new System.Drawing.Size(75, 23);
            this.btClearStatus.TabIndex = 11;
            this.btClearStatus.Text = "*CLS";
            this.btClearStatus.UseVisualStyleBackColor = true;
            this.btClearStatus.Click += new System.EventHandler(this.btClearStatus_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTitle.Location = new System.Drawing.Point(3, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(270, 33);
            this.lbTitle.TabIndex = 10;
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
            this.gbIDN.Size = new System.Drawing.Size(444, 128);
            this.gbIDN.TabIndex = 9;
            this.gbIDN.TabStop = false;
            this.gbIDN.Text = "Instrument ID";
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
            this.tbRevisionCode.Location = new System.Drawing.Point(274, 97);
            this.tbRevisionCode.Name = "tbRevisionCode";
            this.tbRevisionCode.ReadOnly = true;
            this.tbRevisionCode.Size = new System.Drawing.Size(164, 20);
            this.tbRevisionCode.TabIndex = 8;
            this.tbRevisionCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSerialNumber
            // 
            this.tbSerialNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSerialNumber.Location = new System.Drawing.Point(274, 71);
            this.tbSerialNumber.Name = "tbSerialNumber";
            this.tbSerialNumber.ReadOnly = true;
            this.tbSerialNumber.Size = new System.Drawing.Size(164, 20);
            this.tbSerialNumber.TabIndex = 7;
            this.tbSerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbRevisionCode
            // 
            this.lbRevisionCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRevisionCode.Location = new System.Drawing.Point(118, 100);
            this.lbRevisionCode.Name = "lbRevisionCode";
            this.lbRevisionCode.Size = new System.Drawing.Size(150, 13);
            this.lbRevisionCode.TabIndex = 6;
            this.lbRevisionCode.Text = "Revision code:";
            this.lbRevisionCode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbSerialNumber
            // 
            this.lbSerialNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSerialNumber.Location = new System.Drawing.Point(118, 74);
            this.lbSerialNumber.Name = "lbSerialNumber";
            this.lbSerialNumber.Size = new System.Drawing.Size(150, 13);
            this.lbSerialNumber.TabIndex = 5;
            this.lbSerialNumber.Text = "Serial number:";
            this.lbSerialNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbModel
            // 
            this.lbModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbModel.Location = new System.Drawing.Point(118, 48);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(150, 13);
            this.lbModel.TabIndex = 4;
            this.lbModel.Text = "Model:";
            this.lbModel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbModel
            // 
            this.tbModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbModel.Location = new System.Drawing.Point(274, 45);
            this.tbModel.Name = "tbModel";
            this.tbModel.ReadOnly = true;
            this.tbModel.Size = new System.Drawing.Size(164, 20);
            this.tbModel.TabIndex = 3;
            this.tbModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbManufacturer
            // 
            this.tbManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbManufacturer.Location = new System.Drawing.Point(274, 19);
            this.tbManufacturer.Name = "tbManufacturer";
            this.tbManufacturer.ReadOnly = true;
            this.tbManufacturer.Size = new System.Drawing.Size(164, 20);
            this.tbManufacturer.TabIndex = 2;
            this.tbManufacturer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbManufacturer
            // 
            this.lbManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbManufacturer.Location = new System.Drawing.Point(118, 22);
            this.lbManufacturer.Name = "lbManufacturer";
            this.lbManufacturer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbManufacturer.Size = new System.Drawing.Size(150, 13);
            this.lbManufacturer.TabIndex = 1;
            this.lbManufacturer.Text = "Manufacturer:";
            this.lbManufacturer.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // CommonPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbSelfTest);
            this.Controls.Add(this.lbSelfTest);
            this.Controls.Add(this.lbRestore);
            this.Controls.Add(this.btRestore);
            this.Controls.Add(this.btSelfTest);
            this.Controls.Add(this.lbClearStatus);
            this.Controls.Add(this.btClearStatus);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.gbIDN);
            this.Name = "CommonPanel";
            this.Size = new System.Drawing.Size(450, 276);
            this.gbIDN.ResumeLayout(false);
            this.gbIDN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSelfTest;
        private System.Windows.Forms.Label lbSelfTest;
        private System.Windows.Forms.Label lbRestore;
        private System.Windows.Forms.Button btRestore;
        private System.Windows.Forms.Button btSelfTest;
        private System.Windows.Forms.Label lbClearStatus;
        private System.Windows.Forms.Button btClearStatus;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox gbIDN;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TextBox tbRevisionCode;
        private System.Windows.Forms.TextBox tbSerialNumber;
        private System.Windows.Forms.Label lbRevisionCode;
        private System.Windows.Forms.Label lbSerialNumber;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbManufacturer;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.Button btIDN;
    }
}
