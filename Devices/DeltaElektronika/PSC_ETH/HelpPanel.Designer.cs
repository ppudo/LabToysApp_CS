
namespace DeltaElektronika.PSC_ETH
{
    partial class HelpPanel
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
            this.lbItems = new System.Windows.Forms.ListBox();
            this.scHelp = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.scHelp)).BeginInit();
            this.scHelp.Panel1.SuspendLayout();
            this.scHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTitle.Location = new System.Drawing.Point(3, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(83, 33);
            this.lbTitle.TabIndex = 17;
            this.lbTitle.Text = "Help";
            // 
            // lbItems
            // 
            this.lbItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(0, 0);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(162, 531);
            this.lbItems.TabIndex = 18;
            this.lbItems.SelectedIndexChanged += new System.EventHandler(this.lbItems_SelectedIndexChanged);
            // 
            // scHelp
            // 
            this.scHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scHelp.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scHelp.Location = new System.Drawing.Point(3, 36);
            this.scHelp.Name = "scHelp";
            // 
            // scHelp.Panel1
            // 
            this.scHelp.Panel1.Controls.Add(this.lbItems);
            this.scHelp.Size = new System.Drawing.Size(904, 531);
            this.scHelp.SplitterDistance = 162;
            this.scHelp.TabIndex = 19;
            // 
            // HelpPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scHelp);
            this.Controls.Add(this.lbTitle);
            this.Name = "HelpPanel";
            this.Size = new System.Drawing.Size(910, 570);
            this.scHelp.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scHelp)).EndInit();
            this.scHelp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.SplitContainer scHelp;
    }
}
