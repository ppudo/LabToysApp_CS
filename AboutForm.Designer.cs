
namespace LabToysApp
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbAppName = new System.Windows.Forms.Label();
            this.gbImagesAuthors = new System.Windows.Forms.GroupBox();
            this.llPixelPerfect = new System.Windows.Forms.LinkLabel();
            this.llDaveGandy = new System.Windows.Forms.LinkLabel();
            this.llMonkik = new System.Windows.Forms.LinkLabel();
            this.llFreepik = new System.Windows.Forms.LinkLabel();
            this.llFlatart = new System.Windows.Forms.LinkLabel();
            this.llJulienMonty = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbImagesAuthors.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::LabToysApp.Properties.Resources.oscilloscope;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(100, 100);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(132, 99);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(87, 13);
            this.lbVersion.TabIndex = 8;
            this.lbVersion.Text = "Version: v1.2.3.4";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(132, 45);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(139, 13);
            this.lbEmail.TabIndex = 7;
            this.lbEmail.Text = "e-mail: ppudo@outlook.com";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Location = new System.Drawing.Point(132, 32);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(103, 13);
            this.lbAuthor.TabIndex = 6;
            this.lbAuthor.Text = "Author: Paweł Pudo";
            // 
            // lbAppName
            // 
            this.lbAppName.AutoSize = true;
            this.lbAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbAppName.Location = new System.Drawing.Point(118, 12);
            this.lbAppName.Name = "lbAppName";
            this.lbAppName.Size = new System.Drawing.Size(76, 20);
            this.lbAppName.TabIndex = 5;
            this.lbAppName.Text = "LabToys";
            // 
            // gbImagesAuthors
            // 
            this.gbImagesAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbImagesAuthors.Controls.Add(this.llJulienMonty);
            this.gbImagesAuthors.Controls.Add(this.llFlatart);
            this.gbImagesAuthors.Controls.Add(this.llPixelPerfect);
            this.gbImagesAuthors.Controls.Add(this.llDaveGandy);
            this.gbImagesAuthors.Controls.Add(this.llMonkik);
            this.gbImagesAuthors.Controls.Add(this.llFreepik);
            this.gbImagesAuthors.Location = new System.Drawing.Point(12, 118);
            this.gbImagesAuthors.Name = "gbImagesAuthors";
            this.gbImagesAuthors.Size = new System.Drawing.Size(264, 64);
            this.gbImagesAuthors.TabIndex = 9;
            this.gbImagesAuthors.TabStop = false;
            this.gbImagesAuthors.Text = "Images Authors";
            // 
            // llPixelPerfect
            // 
            this.llPixelPerfect.AutoSize = true;
            this.llPixelPerfect.Location = new System.Drawing.Point(53, 38);
            this.llPixelPerfect.Name = "llPixelPerfect";
            this.llPixelPerfect.Size = new System.Drawing.Size(65, 13);
            this.llPixelPerfect.TabIndex = 3;
            this.llPixelPerfect.TabStop = true;
            this.llPixelPerfect.Tag = "https://www.flaticon.com/authors/pixel-perfect";
            this.llPixelPerfect.Text = "Pixel perfect";
            this.llPixelPerfect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClick_LinkClicked);
            // 
            // llDaveGandy
            // 
            this.llDaveGandy.AutoSize = true;
            this.llDaveGandy.Location = new System.Drawing.Point(6, 16);
            this.llDaveGandy.Name = "llDaveGandy";
            this.llDaveGandy.Size = new System.Drawing.Size(67, 13);
            this.llDaveGandy.TabIndex = 2;
            this.llDaveGandy.TabStop = true;
            this.llDaveGandy.Tag = "https://www.flaticon.com/authors/dave-gandy";
            this.llDaveGandy.Text = "Dave Gandy";
            this.llDaveGandy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClick_LinkClicked);
            // 
            // llMonkik
            // 
            this.llMonkik.AutoSize = true;
            this.llMonkik.Location = new System.Drawing.Point(6, 38);
            this.llMonkik.Name = "llMonkik";
            this.llMonkik.Size = new System.Drawing.Size(41, 13);
            this.llMonkik.TabIndex = 1;
            this.llMonkik.TabStop = true;
            this.llMonkik.Tag = "https://www.flaticon.com/authors/monkik";
            this.llMonkik.Text = "monkik";
            this.llMonkik.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClick_LinkClicked);
            // 
            // llFreepik
            // 
            this.llFreepik.AutoSize = true;
            this.llFreepik.Location = new System.Drawing.Point(121, 16);
            this.llFreepik.Name = "llFreepik";
            this.llFreepik.Size = new System.Drawing.Size(42, 13);
            this.llFreepik.TabIndex = 0;
            this.llFreepik.TabStop = true;
            this.llFreepik.Tag = "https://www.flaticon.com/authors/freepik";
            this.llFreepik.Text = "Freepik";
            this.llFreepik.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClick_LinkClicked);
            // 
            // llFlatart
            // 
            this.llFlatart.AutoSize = true;
            this.llFlatart.Location = new System.Drawing.Point(79, 16);
            this.llFlatart.Name = "llFlatart";
            this.llFlatart.Size = new System.Drawing.Size(36, 13);
            this.llFlatart.TabIndex = 4;
            this.llFlatart.TabStop = true;
            this.llFlatart.Tag = "https://www.iconfinder.com/Flatart";
            this.llFlatart.Text = "Flatart";
            this.llFlatart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClick_LinkClicked);
            // 
            // llJulienMonty
            // 
            this.llJulienMonty.AutoSize = true;
            this.llJulienMonty.Location = new System.Drawing.Point(166, 16);
            this.llJulienMonty.Name = "llJulienMonty";
            this.llJulienMonty.Size = new System.Drawing.Size(66, 13);
            this.llJulienMonty.TabIndex = 5;
            this.llJulienMonty.TabStop = true;
            this.llJulienMonty.Tag = "https://icon-icons.com/users/5u5EKEMGUHKJo7iIylWrP/icon-sets/";
            this.llJulienMonty.Text = "Julien Monty";
            this.llJulienMonty.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClick_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 194);
            this.Controls.Add(this.gbImagesAuthors);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.lbAppName);
            this.Controls.Add(this.pbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbImagesAuthors.ResumeLayout(false);
            this.gbImagesAuthors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbAppName;
        private System.Windows.Forms.GroupBox gbImagesAuthors;
        private System.Windows.Forms.LinkLabel llPixelPerfect;
        private System.Windows.Forms.LinkLabel llDaveGandy;
        private System.Windows.Forms.LinkLabel llMonkik;
        private System.Windows.Forms.LinkLabel llFreepik;
        private System.Windows.Forms.LinkLabel llFlatart;
        private System.Windows.Forms.LinkLabel llJulienMonty;
    }
}