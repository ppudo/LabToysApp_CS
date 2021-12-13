
namespace CTS.ASCII_Proto_ETH
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
            this.tsASCIIprotoETH = new System.Windows.Forms.ToolStrip();
            this.tslName = new System.Windows.Forms.ToolStripLabel();
            this.tstbError = new System.Windows.Forms.ToolStripTextBox();
            this.tsContainer = new System.Windows.Forms.ToolStripContainer();
            this.tsbtHome = new System.Windows.Forms.ToolStripButton();
            this.tsbtCommon = new System.Windows.Forms.ToolStripButton();
            this.tsbtInfo = new System.Windows.Forms.ToolStripButton();
            this.tsbtDebug = new System.Windows.Forms.ToolStripButton();
            this.tsbtRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsASCIIprotoETH.SuspendLayout();
            this.tsContainer.TopToolStripPanel.SuspendLayout();
            this.tsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsASCIIprotoETH
            // 
            this.tsASCIIprotoETH.Dock = System.Windows.Forms.DockStyle.None;
            this.tsASCIIprotoETH.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsASCIIprotoETH.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslName,
            this.tsbtHome,
            this.tsbtCommon,
            this.tsbtInfo,
            this.tsbtDebug,
            this.tstbError,
            this.tsbtRefresh});
            this.tsASCIIprotoETH.Location = new System.Drawing.Point(3, 0);
            this.tsASCIIprotoETH.Name = "tsASCIIprotoETH";
            this.tsASCIIprotoETH.Size = new System.Drawing.Size(381, 25);
            this.tsASCIIprotoETH.TabIndex = 2;
            // 
            // tslName
            // 
            this.tslName.Name = "tslName";
            this.tslName.Size = new System.Drawing.Size(130, 22);
            this.tslName.Text = "CTS ASCII Protocol ETH";
            // 
            // tstbError
            // 
            this.tstbError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstbError.Name = "tstbError";
            this.tstbError.ReadOnly = true;
            this.tstbError.Size = new System.Drawing.Size(100, 25);
            // 
            // tsContainer
            // 
            // 
            // tsContainer.ContentPanel
            // 
            this.tsContainer.ContentPanel.Size = new System.Drawing.Size(567, 332);
            this.tsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsContainer.Location = new System.Drawing.Point(0, 0);
            this.tsContainer.Name = "tsContainer";
            this.tsContainer.Size = new System.Drawing.Size(567, 357);
            this.tsContainer.TabIndex = 3;
            this.tsContainer.Text = "toolStripContainer1";
            // 
            // tsContainer.TopToolStripPanel
            // 
            this.tsContainer.TopToolStripPanel.Controls.Add(this.tsASCIIprotoETH);
            // 
            // tsbtHome
            // 
            this.tsbtHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbtHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtHome.Image = global::CTS.Properties.Resources.home;
            this.tsbtHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtHome.Name = "tsbtHome";
            this.tsbtHome.Size = new System.Drawing.Size(23, 22);
            this.tsbtHome.Click += new System.EventHandler(this.tsbChangePanel_Click);
            // 
            // tsbtCommon
            // 
            this.tsbtCommon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtCommon.Image = global::CTS.Properties.Resources.standard;
            this.tsbtCommon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtCommon.Name = "tsbtCommon";
            this.tsbtCommon.Size = new System.Drawing.Size(23, 22);
            this.tsbtCommon.Click += new System.EventHandler(this.tsbChangePanel_Click);
            // 
            // tsbtInfo
            // 
            this.tsbtInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtInfo.Image = global::CTS.Properties.Resources.info;
            this.tsbtInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtInfo.Name = "tsbtInfo";
            this.tsbtInfo.Size = new System.Drawing.Size(23, 22);
            this.tsbtInfo.Click += new System.EventHandler(this.tsbChangePanel_Click);
            // 
            // tsbtDebug
            // 
            this.tsbtDebug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtDebug.Image = global::CTS.Properties.Resources.bug;
            this.tsbtDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtDebug.Name = "tsbtDebug";
            this.tsbtDebug.Size = new System.Drawing.Size(23, 22);
            this.tsbtDebug.Click += new System.EventHandler(this.tsbChangePanel_Click);
            // 
            // tsbtRefresh
            // 
            this.tsbtRefresh.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tsbtRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtRefresh.Image = global::CTS.Properties.Resources.refresh;
            this.tsbtRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtRefresh.Name = "tsbtRefresh";
            this.tsbtRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbtRefresh.Click += new System.EventHandler(this.tsbtRefresh_Click);
            // 
            // DevicePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tsContainer);
            this.Name = "DevicePanel";
            this.Size = new System.Drawing.Size(567, 357);
            this.tsASCIIprotoETH.ResumeLayout(false);
            this.tsASCIIprotoETH.PerformLayout();
            this.tsContainer.TopToolStripPanel.ResumeLayout(false);
            this.tsContainer.TopToolStripPanel.PerformLayout();
            this.tsContainer.ResumeLayout(false);
            this.tsContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsASCIIprotoETH;
        private System.Windows.Forms.ToolStripLabel tslName;
        private System.Windows.Forms.ToolStripButton tsbtHome;
        private System.Windows.Forms.ToolStripButton tsbtCommon;
        private System.Windows.Forms.ToolStripButton tsbtInfo;
        private System.Windows.Forms.ToolStripButton tsbtDebug;
        private System.Windows.Forms.ToolStripTextBox tstbError;
        private System.Windows.Forms.ToolStripContainer tsContainer;
        private System.Windows.Forms.ToolStripButton tsbtRefresh;
    }
}
