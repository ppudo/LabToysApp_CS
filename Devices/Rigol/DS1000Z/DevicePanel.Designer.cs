namespace Rigol.DS1000Z
{
    partial class DevicePanel
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
            this.tsContainer = new System.Windows.Forms.ToolStripContainer();
            this.tsDS1000Z = new System.Windows.Forms.ToolStrip();
            this.tslName = new System.Windows.Forms.ToolStripLabel();
            this.tsbtHome = new System.Windows.Forms.ToolStripButton();
            this.tsbtInfo = new System.Windows.Forms.ToolStripButton();
            this.tsbtDebug = new System.Windows.Forms.ToolStripButton();
            this.tstbError = new System.Windows.Forms.ToolStripTextBox();
            this.tsContainer.TopToolStripPanel.SuspendLayout();
            this.tsContainer.SuspendLayout();
            this.tsDS1000Z.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsContainer
            // 
            this.tsContainer.BottomToolStripPanelVisible = false;
            // 
            // tsContainer.ContentPanel
            // 
            this.tsContainer.ContentPanel.Size = new System.Drawing.Size(564, 315);
            this.tsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsContainer.LeftToolStripPanelVisible = false;
            this.tsContainer.Location = new System.Drawing.Point(0, 0);
            this.tsContainer.Name = "tsContainer";
            this.tsContainer.RightToolStripPanelVisible = false;
            this.tsContainer.Size = new System.Drawing.Size(564, 340);
            this.tsContainer.TabIndex = 1;
            this.tsContainer.Text = "toolStripContainer1";
            // 
            // tsContainer.TopToolStripPanel
            // 
            this.tsContainer.TopToolStripPanel.Controls.Add(this.tsDS1000Z);
            // 
            // tsDS1000Z
            // 
            this.tsDS1000Z.Dock = System.Windows.Forms.DockStyle.None;
            this.tsDS1000Z.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsDS1000Z.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslName,
            this.tsbtHome,
            this.tsbtInfo,
            this.tsbtDebug,
            this.tstbError});
            this.tsDS1000Z.Location = new System.Drawing.Point(3, 0);
            this.tsDS1000Z.Name = "tsDS1000Z";
            this.tsDS1000Z.Size = new System.Drawing.Size(256, 25);
            this.tsDS1000Z.TabIndex = 1;
            // 
            // tslName
            // 
            this.tslName.Name = "tslName";
            this.tslName.Size = new System.Drawing.Size(82, 22);
            this.tslName.Text = "Rigol DS1000Z";
            // 
            // tsbtHome
            // 
            this.tsbtHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtHome.Image = global::Rigol.Properties.Resources.home;
            this.tsbtHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtHome.Name = "tsbtHome";
            this.tsbtHome.Size = new System.Drawing.Size(23, 22);
            this.tsbtHome.Click += new System.EventHandler(this.tsbChangePanel_Click);
            // 
            // tsbtInfo
            // 
            this.tsbtInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtInfo.Image = global::Rigol.Properties.Resources.info;
            this.tsbtInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtInfo.Name = "tsbtInfo";
            this.tsbtInfo.Size = new System.Drawing.Size(23, 22);
            this.tsbtInfo.Click += new System.EventHandler(this.tsbChangePanel_Click);
            // 
            // tsbtDebug
            // 
            this.tsbtDebug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtDebug.Image = global::Rigol.Properties.Resources.bug;
            this.tsbtDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtDebug.Name = "tsbtDebug";
            this.tsbtDebug.Size = new System.Drawing.Size(23, 22);
            this.tsbtDebug.Click += new System.EventHandler(this.tsbChangePanel_Click);
            // 
            // tstbError
            // 
            this.tstbError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstbError.Name = "tstbError";
            this.tstbError.ReadOnly = true;
            this.tstbError.Size = new System.Drawing.Size(100, 25);
            // 
            // DevicePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tsContainer);
            this.Name = "DevicePanel";
            this.Size = new System.Drawing.Size(564, 340);
            this.tsContainer.TopToolStripPanel.ResumeLayout(false);
            this.tsContainer.TopToolStripPanel.PerformLayout();
            this.tsContainer.ResumeLayout(false);
            this.tsContainer.PerformLayout();
            this.tsDS1000Z.ResumeLayout(false);
            this.tsDS1000Z.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tsContainer;
        private System.Windows.Forms.ToolStrip tsDS1000Z;
        private System.Windows.Forms.ToolStripLabel tslName;
        private System.Windows.Forms.ToolStripButton tsbtHome;
        private System.Windows.Forms.ToolStripButton tsbtInfo;
        private System.Windows.Forms.ToolStripButton tsbtDebug;
        private System.Windows.Forms.ToolStripTextBox tstbError;
    }
}
