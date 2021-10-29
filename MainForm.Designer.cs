
namespace LabToysApp
{
    partial class MainForm
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLangDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLangEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLangPoland = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGitHub = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGitLabtoysPython = new System.Windows.Forms.ToolStripMenuItem();
            this.tamiGitLabToysCS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGitLabToysAppCS = new System.Windows.Forms.ToolStripMenuItem();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.btSeparateWindow = new System.Windows.Forms.Button();
            this.btDeleteDevice = new System.Windows.Forms.Button();
            this.btAddDevice = new System.Windows.Forms.Button();
            this.tvDevices = new System.Windows.Forms.TreeView();
            this.ilDevicesList = new System.Windows.Forms.ImageList(this.components);
            this.ttTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiAbout,
            this.tsmiGitHub});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(868, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLanguage});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "File";
            // 
            // tsmiLanguage
            // 
            this.tsmiLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLangDefault,
            this.tsmiLangEnglish,
            this.tsmiLangPoland});
            this.tsmiLanguage.Image = global::LabToysApp.Properties.Resources.translate;
            this.tsmiLanguage.Name = "tsmiLanguage";
            this.tsmiLanguage.Size = new System.Drawing.Size(126, 22);
            this.tsmiLanguage.Text = "Language";
            // 
            // tsmiLangDefault
            // 
            this.tsmiLangDefault.Checked = true;
            this.tsmiLangDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiLangDefault.Name = "tsmiLangDefault";
            this.tsmiLangDefault.Size = new System.Drawing.Size(112, 22);
            this.tsmiLangDefault.Text = "Default";
            this.tsmiLangDefault.Click += new System.EventHandler(this.tsmiLangDefault_Click);
            // 
            // tsmiLangEnglish
            // 
            this.tsmiLangEnglish.Image = global::LabToysApp.Properties.Resources.united_kingdom;
            this.tsmiLangEnglish.Name = "tsmiLangEnglish";
            this.tsmiLangEnglish.Size = new System.Drawing.Size(112, 22);
            this.tsmiLangEnglish.Text = "English";
            this.tsmiLangEnglish.Click += new System.EventHandler(this.tsmiLangEnglish_Click);
            // 
            // tsmiLangPoland
            // 
            this.tsmiLangPoland.Image = global::LabToysApp.Properties.Resources.poland;
            this.tsmiLangPoland.Name = "tsmiLangPoland";
            this.tsmiLangPoland.Size = new System.Drawing.Size(112, 22);
            this.tsmiLangPoland.Text = "Polski";
            this.tsmiLangPoland.Click += new System.EventHandler(this.tsmiLangPoland_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(52, 20);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsmiGitHub
            // 
            this.tsmiGitHub.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGitLabtoysPython,
            this.tamiGitLabToysCS,
            this.tsmiGitLabToysAppCS});
            this.tsmiGitHub.Image = global::LabToysApp.Properties.Resources.github;
            this.tsmiGitHub.Name = "tsmiGitHub";
            this.tsmiGitHub.Size = new System.Drawing.Size(73, 20);
            this.tsmiGitHub.Text = "GitHub";
            // 
            // tsmiGitLabtoysPython
            // 
            this.tsmiGitLabtoysPython.Image = global::LabToysApp.Properties.Resources.python;
            this.tsmiGitLabtoysPython.Name = "tsmiGitLabtoysPython";
            this.tsmiGitLabtoysPython.Size = new System.Drawing.Size(164, 22);
            this.tsmiGitLabtoysPython.Tag = "https://github.com/ppudo/labtoys_python";
            this.tsmiGitLabtoysPython.Text = "labtoys - python";
            this.tsmiGitLabtoysPython.Click += new System.EventHandler(this.tsmiGit_Click);
            // 
            // tamiGitLabToysCS
            // 
            this.tamiGitLabToysCS.Image = global::LabToysApp.Properties.Resources.csharp;
            this.tamiGitLabToysCS.Name = "tamiGitLabToysCS";
            this.tamiGitLabToysCS.Size = new System.Drawing.Size(164, 22);
            this.tamiGitLabToysCS.Tag = "https://github.com/ppudo/LabToys_Csharp";
            this.tamiGitLabToysCS.Text = "LabToys - C#";
            this.tamiGitLabToysCS.Click += new System.EventHandler(this.tsmiGit_Click);
            // 
            // tsmiGitLabToysAppCS
            // 
            this.tsmiGitLabToysAppCS.Image = global::LabToysApp.Properties.Resources.csharp;
            this.tsmiGitLabToysAppCS.Name = "tsmiGitLabToysAppCS";
            this.tsmiGitLabToysAppCS.Size = new System.Drawing.Size(164, 22);
            this.tsmiGitLabToysAppCS.Tag = "https://github.com/ppudo/LabToysApp_CS";
            this.tsmiGitLabToysAppCS.Text = "LabToysApp - C#";
            this.tsmiGitLabToysAppCS.Click += new System.EventHandler(this.tsmiGit_Click);
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.Location = new System.Drawing.Point(0, 24);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.btSeparateWindow);
            this.scMain.Panel1.Controls.Add(this.btDeleteDevice);
            this.scMain.Panel1.Controls.Add(this.btAddDevice);
            this.scMain.Panel1.Controls.Add(this.tvDevices);
            this.scMain.Size = new System.Drawing.Size(868, 488);
            this.scMain.SplitterDistance = 225;
            this.scMain.TabIndex = 1;
            // 
            // btSeparateWindow
            // 
            this.btSeparateWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSeparateWindow.BackgroundImage = global::LabToysApp.Properties.Resources.window;
            this.btSeparateWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSeparateWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSeparateWindow.ForeColor = System.Drawing.SystemColors.Control;
            this.btSeparateWindow.Location = new System.Drawing.Point(197, 3);
            this.btSeparateWindow.Name = "btSeparateWindow";
            this.btSeparateWindow.Size = new System.Drawing.Size(25, 25);
            this.btSeparateWindow.TabIndex = 3;
            this.ttTipMain.SetToolTip(this.btSeparateWindow, "Move current device to separete window");
            this.btSeparateWindow.UseVisualStyleBackColor = true;
            this.btSeparateWindow.Click += new System.EventHandler(this.btSeparateWindow_Click);
            // 
            // btDeleteDevice
            // 
            this.btDeleteDevice.BackgroundImage = global::LabToysApp.Properties.Resources.minus_red;
            this.btDeleteDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDeleteDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteDevice.ForeColor = System.Drawing.SystemColors.Control;
            this.btDeleteDevice.Location = new System.Drawing.Point(34, 3);
            this.btDeleteDevice.Name = "btDeleteDevice";
            this.btDeleteDevice.Size = new System.Drawing.Size(25, 25);
            this.btDeleteDevice.TabIndex = 2;
            this.ttTipMain.SetToolTip(this.btDeleteDevice, "Delete device...");
            this.btDeleteDevice.UseVisualStyleBackColor = true;
            this.btDeleteDevice.Click += new System.EventHandler(this.btDeleteDevice_Click);
            // 
            // btAddDevice
            // 
            this.btAddDevice.BackgroundImage = global::LabToysApp.Properties.Resources.plus_green;
            this.btAddDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAddDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddDevice.ForeColor = System.Drawing.SystemColors.Control;
            this.btAddDevice.Location = new System.Drawing.Point(3, 3);
            this.btAddDevice.Name = "btAddDevice";
            this.btAddDevice.Size = new System.Drawing.Size(25, 25);
            this.btAddDevice.TabIndex = 1;
            this.ttTipMain.SetToolTip(this.btAddDevice, "Add device...");
            this.btAddDevice.UseVisualStyleBackColor = true;
            this.btAddDevice.Click += new System.EventHandler(this.btAddDevice_Click);
            // 
            // tvDevices
            // 
            this.tvDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvDevices.ImageIndex = 0;
            this.tvDevices.ImageList = this.ilDevicesList;
            this.tvDevices.Location = new System.Drawing.Point(3, 34);
            this.tvDevices.Name = "tvDevices";
            this.tvDevices.SelectedImageIndex = 0;
            this.tvDevices.Size = new System.Drawing.Size(219, 451);
            this.tvDevices.TabIndex = 0;
            this.tvDevices.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDevices_AfterSelect);
            // 
            // ilDevicesList
            // 
            this.ilDevicesList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilDevicesList.ImageStream")));
            this.ilDevicesList.TransparentColor = System.Drawing.Color.Transparent;
            this.ilDevicesList.Images.SetKeyName(0, "arrow.png");
            this.ilDevicesList.Images.SetKeyName(1, "bug.png");
            this.ilDevicesList.Images.SetKeyName(2, "oscilloscope.png");
            this.ilDevicesList.Images.SetKeyName(3, "power-supply.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 512);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LabToys";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.TreeView tvDevices;
        private System.Windows.Forms.ImageList ilDevicesList;
        private System.Windows.Forms.Button btAddDevice;
        private System.Windows.Forms.Button btDeleteDevice;
        private System.Windows.Forms.Button btSeparateWindow;
        private System.Windows.Forms.ToolTip ttTipMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiLanguage;
        private System.Windows.Forms.ToolStripMenuItem tsmiLangDefault;
        private System.Windows.Forms.ToolStripMenuItem tsmiLangEnglish;
        private System.Windows.Forms.ToolStripMenuItem tsmiLangPoland;
        private System.Windows.Forms.ToolStripMenuItem tsmiGitHub;
        private System.Windows.Forms.ToolStripMenuItem tsmiGitLabtoysPython;
        private System.Windows.Forms.ToolStripMenuItem tamiGitLabToysCS;
        private System.Windows.Forms.ToolStripMenuItem tsmiGitLabToysAppCS;
    }
}

