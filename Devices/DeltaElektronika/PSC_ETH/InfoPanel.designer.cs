
namespace DeltaElektronika.PSC_ETH
{
    partial class InfoPanel
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
            this.llProgrammingGuide = new System.Windows.Forms.LinkLabel();
            this.lbProgrammingGuide = new System.Windows.Forms.Label();
            this.llManufacturerPage = new System.Windows.Forms.LinkLabel();
            this.lbManufacturerPage = new System.Windows.Forms.Label();
            this.lbProductPage = new System.Windows.Forms.Label();
            this.llProductPage = new System.Windows.Forms.LinkLabel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbLastUpdate = new System.Windows.Forms.Label();
            this.gbImagesAuthors = new System.Windows.Forms.GroupBox();
            this.llPixelPerfect = new System.Windows.Forms.LinkLabel();
            this.llFreepik = new System.Windows.Forms.LinkLabel();
            this.lbVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.gbImagesAuthors.SuspendLayout();
            this.SuspendLayout();
            // 
            // llProgrammingGuide
            // 
            this.llProgrammingGuide.AutoSize = true;
            this.llProgrammingGuide.Location = new System.Drawing.Point(123, 169);
            this.llProgrammingGuide.Name = "llProgrammingGuide";
            this.llProgrammingGuide.Size = new System.Drawing.Size(97, 13);
            this.llProgrammingGuide.TabIndex = 24;
            this.llProgrammingGuide.TabStop = true;
            this.llProgrammingGuide.Tag = "https://www.delta-elektronika.nl/upload/MANUAL_ETHERNET_CARD_AND_MODULE.pdf";
            this.llProgrammingGuide.Text = "Programming guide";
            this.llProgrammingGuide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClick_LinkClicked);
            // 
            // lbProgrammingGuide
            // 
            this.lbProgrammingGuide.AutoSize = true;
            this.lbProgrammingGuide.Location = new System.Drawing.Point(5, 169);
            this.lbProgrammingGuide.Name = "lbProgrammingGuide";
            this.lbProgrammingGuide.Size = new System.Drawing.Size(100, 13);
            this.lbProgrammingGuide.TabIndex = 23;
            this.lbProgrammingGuide.Text = "Programming guide:";
            // 
            // llManufacturerPage
            // 
            this.llManufacturerPage.AutoSize = true;
            this.llManufacturerPage.Location = new System.Drawing.Point(123, 144);
            this.llManufacturerPage.Name = "llManufacturerPage";
            this.llManufacturerPage.Size = new System.Drawing.Size(145, 13);
            this.llManufacturerPage.TabIndex = 18;
            this.llManufacturerPage.TabStop = true;
            this.llManufacturerPage.Tag = "https://www.delta-elektronika.nl/en/";
            this.llManufacturerPage.Text = "www.delta-elektronika.nl/en/";
            this.llManufacturerPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClick_LinkClicked);
            // 
            // lbManufacturerPage
            // 
            this.lbManufacturerPage.AutoSize = true;
            this.lbManufacturerPage.Location = new System.Drawing.Point(5, 144);
            this.lbManufacturerPage.Name = "lbManufacturerPage";
            this.lbManufacturerPage.Size = new System.Drawing.Size(112, 13);
            this.lbManufacturerPage.TabIndex = 17;
            this.lbManufacturerPage.Text = "Manufacturer website:";
            // 
            // lbProductPage
            // 
            this.lbProductPage.AutoSize = true;
            this.lbProductPage.Location = new System.Drawing.Point(5, 119);
            this.lbProductPage.Name = "lbProductPage";
            this.lbProductPage.Size = new System.Drawing.Size(86, 13);
            this.lbProductPage.TabIndex = 16;
            this.lbProductPage.Text = "Product website:";
            // 
            // llProductPage
            // 
            this.llProductPage.AutoSize = true;
            this.llProductPage.Location = new System.Drawing.Point(123, 119);
            this.llProductPage.Name = "llProductPage";
            this.llProductPage.Size = new System.Drawing.Size(137, 13);
            this.llProductPage.TabIndex = 15;
            this.llProductPage.TabStop = true;
            this.llProductPage.Tag = "https://www.delta-elektronika.nl/en/products/interfaces/ethernet-interface.html";
            this.llProductPage.Text = "Delta Elektronika PSC-ETH";
            this.llProductPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClick_LinkClicked);
            // 
            // pbImage
            // 
            this.pbImage.Image = global::DeltaElektronika.Properties.Resources.power_supply;
            this.pbImage.Location = new System.Drawing.Point(3, 3);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(100, 100);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 14;
            this.pbImage.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbName.Location = new System.Drawing.Point(109, 3);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(304, 66);
            this.lbName.TabIndex = 13;
            this.lbName.Text = "Delta Elektronika\r\nPSC-ETH";
            // 
            // lbLastUpdate
            // 
            this.lbLastUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbLastUpdate.AutoSize = true;
            this.lbLastUpdate.Location = new System.Drawing.Point(3, 268);
            this.lbLastUpdate.Name = "lbLastUpdate";
            this.lbLastUpdate.Size = new System.Drawing.Size(123, 13);
            this.lbLastUpdate.TabIndex = 25;
            this.lbLastUpdate.Text = "Last update: 2020.11.10";
            // 
            // gbImagesAuthors
            // 
            this.gbImagesAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbImagesAuthors.Controls.Add(this.llPixelPerfect);
            this.gbImagesAuthors.Controls.Add(this.llFreepik);
            this.gbImagesAuthors.Location = new System.Drawing.Point(3, 284);
            this.gbImagesAuthors.Name = "gbImagesAuthors";
            this.gbImagesAuthors.Size = new System.Drawing.Size(446, 46);
            this.gbImagesAuthors.TabIndex = 26;
            this.gbImagesAuthors.TabStop = false;
            this.gbImagesAuthors.Text = "Images Authors";
            // 
            // llPixelPerfect
            // 
            this.llPixelPerfect.AutoSize = true;
            this.llPixelPerfect.Location = new System.Drawing.Point(54, 16);
            this.llPixelPerfect.Name = "llPixelPerfect";
            this.llPixelPerfect.Size = new System.Drawing.Size(65, 13);
            this.llPixelPerfect.TabIndex = 3;
            this.llPixelPerfect.TabStop = true;
            this.llPixelPerfect.Tag = "https://www.flaticon.com/authors/pixel-perfect";
            this.llPixelPerfect.Text = "Pixel perfect";
            this.llPixelPerfect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClick_LinkClicked);
            // 
            // llFreepik
            // 
            this.llFreepik.AutoSize = true;
            this.llFreepik.Location = new System.Drawing.Point(6, 16);
            this.llFreepik.Name = "llFreepik";
            this.llFreepik.Size = new System.Drawing.Size(42, 13);
            this.llFreepik.TabIndex = 0;
            this.llFreepik.TabStop = true;
            this.llFreepik.Tag = "https://www.flaticon.com/authors/freepik";
            this.llFreepik.Text = "Freepik";
            this.llFreepik.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClick_LinkClicked);
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(133, 69);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbVersion.Size = new System.Drawing.Size(87, 13);
            this.lbVersion.TabIndex = 27;
            this.lbVersion.Text = "Version: v1.2.3.4";
            this.lbVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.gbImagesAuthors);
            this.Controls.Add(this.lbLastUpdate);
            this.Controls.Add(this.llProgrammingGuide);
            this.Controls.Add(this.lbProgrammingGuide);
            this.Controls.Add(this.llManufacturerPage);
            this.Controls.Add(this.lbManufacturerPage);
            this.Controls.Add(this.lbProductPage);
            this.Controls.Add(this.llProductPage);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lbName);
            this.Name = "InfoPanel";
            this.Size = new System.Drawing.Size(452, 333);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.gbImagesAuthors.ResumeLayout(false);
            this.gbImagesAuthors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llProgrammingGuide;
        private System.Windows.Forms.Label lbProgrammingGuide;
        private System.Windows.Forms.LinkLabel llManufacturerPage;
        private System.Windows.Forms.Label lbManufacturerPage;
        private System.Windows.Forms.Label lbProductPage;
        private System.Windows.Forms.LinkLabel llProductPage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbLastUpdate;
        private System.Windows.Forms.GroupBox gbImagesAuthors;
        private System.Windows.Forms.LinkLabel llPixelPerfect;
        private System.Windows.Forms.LinkLabel llFreepik;
        private System.Windows.Forms.Label lbVersion;
    }
}
