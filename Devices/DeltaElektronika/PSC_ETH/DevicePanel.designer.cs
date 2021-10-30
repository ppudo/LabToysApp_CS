namespace DeltaElektronika.PSC_ETH
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
            this.tsPSC_ETH = new System.Windows.Forms.ToolStrip();
            this.tslName = new System.Windows.Forms.ToolStripLabel();
            this.tsbtHome = new System.Windows.Forms.ToolStripButton();
            this.tsbtSequencer = new System.Windows.Forms.ToolStripButton();
            this.tsbtInfo = new System.Windows.Forms.ToolStripButton();
            this.tsbtDebug = new System.Windows.Forms.ToolStripButton();
            this.tstbError = new System.Windows.Forms.ToolStripTextBox();
            this.tsContainer.TopToolStripPanel.SuspendLayout();
            this.tsContainer.SuspendLayout();
            this.tsPSC_ETH.SuspendLayout();
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
            this.tsContainer.TopToolStripPanel.Controls.Add(this.tsPSC_ETH);
            // 
            // tsPSC_ETH
            // 
            this.tsPSC_ETH.Dock = System.Windows.Forms.DockStyle.None;
            this.tsPSC_ETH.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsPSC_ETH.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslName,
            this.tsbtHome,
            this.tsbtSequencer,
            this.tsbtInfo,
            this.tsbtDebug,
            this.tstbError});
            this.tsPSC_ETH.Location = new System.Drawing.Point(3, 0);
            this.tsPSC_ETH.Name = "tsPSC_ETH";
            this.tsPSC_ETH.Size = new System.Drawing.Size(282, 25);
            this.tsPSC_ETH.TabIndex = 1;
            // 
            // tslName
            // 
            this.tslName.Name = "tslName";
            this.tslName.Size = new System.Drawing.Size(54, 22);
            this.tslName.Text = "PSC_ETH";
            // 
            // tsbtHome
            // 
            this.tsbtHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtHome.Image = global::DeltaElektronika.Properties.Resources.home;
            this.tsbtHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtHome.Name = "tsbtHome";
            this.tsbtHome.Size = new System.Drawing.Size(23, 22);
            this.tsbtHome.Click += new System.EventHandler(this.tsbChangePanel_Click);
            // 
            // tsbtSequencer
            // 
            this.tsbtSequencer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtSequencer.Image = global::DeltaElektronika.Properties.Resources.sequencer;
            this.tsbtSequencer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtSequencer.Name = "tsbtSequencer";
            this.tsbtSequencer.Size = new System.Drawing.Size(23, 22);
            this.tsbtSequencer.Click += new System.EventHandler(this.tsbChangePanel_Click);
            // 
            // tsbtInfo
            // 
            this.tsbtInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtInfo.Image = global::DeltaElektronika.Properties.Resources.info;
            this.tsbtInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtInfo.Name = "tsbtInfo";
            this.tsbtInfo.Size = new System.Drawing.Size(23, 22);
            this.tsbtInfo.Click += new System.EventHandler(this.tsbChangePanel_Click);
            // 
            // tsbtDebug
            // 
            this.tsbtDebug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtDebug.Image = global::DeltaElektronika.Properties.Resources.bug;
            this.tsbtDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtDebug.Name = "tsbtDebug";
            this.tsbtDebug.Size = new System.Drawing.Size(23, 22);
            this.tsbtDebug.Click += new System.EventHandler(this.tsbChangePanel_Click);
            // 
            // tstbError
            // 
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
            this.tsPSC_ETH.ResumeLayout(false);
            this.tsPSC_ETH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tsContainer;
        private System.Windows.Forms.ToolStrip tsPSC_ETH;
        private System.Windows.Forms.ToolStripLabel tslName;
        private System.Windows.Forms.ToolStripButton tsbtHome;
        private System.Windows.Forms.ToolStripButton tsbtInfo;
        private System.Windows.Forms.ToolStripButton tsbtDebug;
        private System.Windows.Forms.ToolStripTextBox tstbError;
        private System.Windows.Forms.ToolStripButton tsbtSequencer;
    }
}
