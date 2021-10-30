namespace DebugDevice
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
            this.pbDebug = new System.Windows.Forms.PictureBox();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbDebug = new System.Windows.Forms.Label();
            this.tcDebug = new System.Windows.Forms.TabControl();
            this.tpLan = new System.Windows.Forms.TabPage();
            this.btLanDebug3 = new System.Windows.Forms.Button();
            this.btLanDebug2 = new System.Windows.Forms.Button();
            this.btLanDebug1 = new System.Windows.Forms.Button();
            this.gbCommands = new System.Windows.Forms.GroupBox();
            this.tbLanOutput = new System.Windows.Forms.TextBox();
            this.chbLanRespond = new System.Windows.Forms.CheckBox();
            this.chbLanStayConnected = new System.Windows.Forms.CheckBox();
            this.chbLanEndingCustom = new System.Windows.Forms.CheckBox();
            this.chbLanEndingCRNL = new System.Windows.Forms.CheckBox();
            this.chbLanEndingNLCR = new System.Windows.Forms.CheckBox();
            this.chbLanEndingCR = new System.Windows.Forms.CheckBox();
            this.chbLanEndingNL = new System.Windows.Forms.CheckBox();
            this.tbLanEnding = new System.Windows.Forms.TextBox();
            this.lbLanEnding = new System.Windows.Forms.Label();
            this.btLanSend = new System.Windows.Forms.Button();
            this.tbLanInput = new System.Windows.Forms.TextBox();
            this.lbLanError = new System.Windows.Forms.Label();
            this.tbLanError = new System.Windows.Forms.TextBox();
            this.btLanConnect = new System.Windows.Forms.Button();
            this.btLanCreate = new System.Windows.Forms.Button();
            this.gbHost = new System.Windows.Forms.GroupBox();
            this.lbLanTimeout = new System.Windows.Forms.Label();
            this.nudLanTimeout = new System.Windows.Forms.NumericUpDown();
            this.lbLanPort = new System.Windows.Forms.Label();
            this.nudLanPort = new System.Windows.Forms.NumericUpDown();
            this.tbLanIP = new System.Windows.Forms.TextBox();
            this.lbLanIP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDebug)).BeginInit();
            this.tcDebug.SuspendLayout();
            this.tpLan.SuspendLayout();
            this.gbCommands.SuspendLayout();
            this.gbHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLanTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLanPort)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDebug
            // 
            this.pbDebug.Image = global::DebugDevice.Properties.Resources.bug;
            this.pbDebug.Location = new System.Drawing.Point(3, 3);
            this.pbDebug.Name = "pbDebug";
            this.pbDebug.Size = new System.Drawing.Size(50, 50);
            this.pbDebug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDebug.TabIndex = 1;
            this.pbDebug.TabStop = false;
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(83, 36);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbVersion.Size = new System.Drawing.Size(87, 13);
            this.lbVersion.TabIndex = 4;
            this.lbVersion.Text = "Version: v1.2.3.4";
            // 
            // lbDebug
            // 
            this.lbDebug.AutoSize = true;
            this.lbDebug.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDebug.Location = new System.Drawing.Point(59, 3);
            this.lbDebug.Name = "lbDebug";
            this.lbDebug.Size = new System.Drawing.Size(185, 33);
            this.lbDebug.TabIndex = 3;
            this.lbDebug.Text = "DEBUG MODE";
            // 
            // tcDebug
            // 
            this.tcDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcDebug.Controls.Add(this.tpLan);
            this.tcDebug.Location = new System.Drawing.Point(3, 59);
            this.tcDebug.Name = "tcDebug";
            this.tcDebug.SelectedIndex = 0;
            this.tcDebug.Size = new System.Drawing.Size(623, 431);
            this.tcDebug.TabIndex = 5;
            // 
            // tpLan
            // 
            this.tpLan.Controls.Add(this.btLanDebug3);
            this.tpLan.Controls.Add(this.btLanDebug2);
            this.tpLan.Controls.Add(this.btLanDebug1);
            this.tpLan.Controls.Add(this.gbCommands);
            this.tpLan.Controls.Add(this.lbLanError);
            this.tpLan.Controls.Add(this.tbLanError);
            this.tpLan.Controls.Add(this.btLanConnect);
            this.tpLan.Controls.Add(this.btLanCreate);
            this.tpLan.Controls.Add(this.gbHost);
            this.tpLan.Location = new System.Drawing.Point(4, 22);
            this.tpLan.Name = "tpLan";
            this.tpLan.Padding = new System.Windows.Forms.Padding(3);
            this.tpLan.Size = new System.Drawing.Size(615, 405);
            this.tpLan.TabIndex = 0;
            this.tpLan.Text = "LAN";
            this.tpLan.UseVisualStyleBackColor = true;
            // 
            // btLanDebug3
            // 
            this.btLanDebug3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLanDebug3.Location = new System.Drawing.Point(168, 376);
            this.btLanDebug3.Name = "btLanDebug3";
            this.btLanDebug3.Size = new System.Drawing.Size(75, 23);
            this.btLanDebug3.TabIndex = 18;
            this.btLanDebug3.Text = "Debug 3";
            this.btLanDebug3.UseVisualStyleBackColor = true;
            this.btLanDebug3.Click += new System.EventHandler(this.btLanDebug3_Click);
            // 
            // btLanDebug2
            // 
            this.btLanDebug2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLanDebug2.Location = new System.Drawing.Point(87, 376);
            this.btLanDebug2.Name = "btLanDebug2";
            this.btLanDebug2.Size = new System.Drawing.Size(75, 23);
            this.btLanDebug2.TabIndex = 17;
            this.btLanDebug2.Text = "Debug 2";
            this.btLanDebug2.UseVisualStyleBackColor = true;
            this.btLanDebug2.Click += new System.EventHandler(this.btLanDebug2_Click);
            // 
            // btLanDebug1
            // 
            this.btLanDebug1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLanDebug1.Location = new System.Drawing.Point(6, 376);
            this.btLanDebug1.Name = "btLanDebug1";
            this.btLanDebug1.Size = new System.Drawing.Size(75, 23);
            this.btLanDebug1.TabIndex = 16;
            this.btLanDebug1.Text = "Debug 1";
            this.btLanDebug1.UseVisualStyleBackColor = true;
            this.btLanDebug1.Click += new System.EventHandler(this.btLanDebug1_Click);
            // 
            // gbCommands
            // 
            this.gbCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCommands.Controls.Add(this.tbLanOutput);
            this.gbCommands.Controls.Add(this.chbLanRespond);
            this.gbCommands.Controls.Add(this.chbLanStayConnected);
            this.gbCommands.Controls.Add(this.chbLanEndingCustom);
            this.gbCommands.Controls.Add(this.chbLanEndingCRNL);
            this.gbCommands.Controls.Add(this.chbLanEndingNLCR);
            this.gbCommands.Controls.Add(this.chbLanEndingCR);
            this.gbCommands.Controls.Add(this.chbLanEndingNL);
            this.gbCommands.Controls.Add(this.tbLanEnding);
            this.gbCommands.Controls.Add(this.lbLanEnding);
            this.gbCommands.Controls.Add(this.btLanSend);
            this.gbCommands.Controls.Add(this.tbLanInput);
            this.gbCommands.Location = new System.Drawing.Point(6, 114);
            this.gbCommands.Name = "gbCommands";
            this.gbCommands.Size = new System.Drawing.Size(603, 256);
            this.gbCommands.TabIndex = 15;
            this.gbCommands.TabStop = false;
            this.gbCommands.Text = "Commands";
            // 
            // tbLanOutput
            // 
            this.tbLanOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLanOutput.Location = new System.Drawing.Point(6, 126);
            this.tbLanOutput.Multiline = true;
            this.tbLanOutput.Name = "tbLanOutput";
            this.tbLanOutput.ReadOnly = true;
            this.tbLanOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLanOutput.Size = new System.Drawing.Size(591, 124);
            this.tbLanOutput.TabIndex = 18;
            // 
            // chbLanRespond
            // 
            this.chbLanRespond.AutoSize = true;
            this.chbLanRespond.Enabled = false;
            this.chbLanRespond.Location = new System.Drawing.Point(148, 103);
            this.chbLanRespond.Name = "chbLanRespond";
            this.chbLanRespond.Size = new System.Drawing.Size(104, 17);
            this.chbLanRespond.TabIndex = 17;
            this.chbLanRespond.Text = "Wait for respond";
            this.chbLanRespond.UseVisualStyleBackColor = true;
            // 
            // chbLanStayConnected
            // 
            this.chbLanStayConnected.AutoSize = true;
            this.chbLanStayConnected.Location = new System.Drawing.Point(6, 103);
            this.chbLanStayConnected.Name = "chbLanStayConnected";
            this.chbLanStayConnected.Size = new System.Drawing.Size(102, 17);
            this.chbLanStayConnected.TabIndex = 16;
            this.chbLanStayConnected.Text = "Stay Connected";
            this.chbLanStayConnected.UseVisualStyleBackColor = true;
            // 
            // chbLanEndingCustom
            // 
            this.chbLanEndingCustom.AutoSize = true;
            this.chbLanEndingCustom.Enabled = false;
            this.chbLanEndingCustom.Location = new System.Drawing.Point(282, 80);
            this.chbLanEndingCustom.Name = "chbLanEndingCustom";
            this.chbLanEndingCustom.Size = new System.Drawing.Size(15, 14);
            this.chbLanEndingCustom.TabIndex = 15;
            this.chbLanEndingCustom.UseVisualStyleBackColor = true;
            this.chbLanEndingCustom.CheckedChanged += new System.EventHandler(this.chbLanEnding_CheckedChanged);
            // 
            // chbLanEndingCRNL
            // 
            this.chbLanEndingCRNL.AutoSize = true;
            this.chbLanEndingCRNL.Enabled = false;
            this.chbLanEndingCRNL.Location = new System.Drawing.Point(215, 80);
            this.chbLanEndingCRNL.Name = "chbLanEndingCRNL";
            this.chbLanEndingCRNL.Size = new System.Drawing.Size(61, 17);
            this.chbLanEndingCRNL.TabIndex = 14;
            this.chbLanEndingCRNL.Text = "CR+NL";
            this.chbLanEndingCRNL.UseVisualStyleBackColor = true;
            this.chbLanEndingCRNL.CheckedChanged += new System.EventHandler(this.chbLanEnding_CheckedChanged);
            // 
            // chbLanEndingNLCR
            // 
            this.chbLanEndingNLCR.AutoSize = true;
            this.chbLanEndingNLCR.Enabled = false;
            this.chbLanEndingNLCR.Location = new System.Drawing.Point(148, 80);
            this.chbLanEndingNLCR.Name = "chbLanEndingNLCR";
            this.chbLanEndingNLCR.Size = new System.Drawing.Size(61, 17);
            this.chbLanEndingNLCR.TabIndex = 13;
            this.chbLanEndingNLCR.Text = "NL+CR";
            this.chbLanEndingNLCR.UseVisualStyleBackColor = true;
            this.chbLanEndingNLCR.CheckedChanged += new System.EventHandler(this.chbLanEnding_CheckedChanged);
            // 
            // chbLanEndingCR
            // 
            this.chbLanEndingCR.AutoSize = true;
            this.chbLanEndingCR.Enabled = false;
            this.chbLanEndingCR.Location = new System.Drawing.Point(101, 80);
            this.chbLanEndingCR.Name = "chbLanEndingCR";
            this.chbLanEndingCR.Size = new System.Drawing.Size(41, 17);
            this.chbLanEndingCR.TabIndex = 12;
            this.chbLanEndingCR.Text = "CR";
            this.chbLanEndingCR.UseVisualStyleBackColor = true;
            this.chbLanEndingCR.CheckedChanged += new System.EventHandler(this.chbLanEnding_CheckedChanged);
            // 
            // chbLanEndingNL
            // 
            this.chbLanEndingNL.AutoSize = true;
            this.chbLanEndingNL.Checked = true;
            this.chbLanEndingNL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLanEndingNL.Enabled = false;
            this.chbLanEndingNL.Location = new System.Drawing.Point(55, 80);
            this.chbLanEndingNL.Name = "chbLanEndingNL";
            this.chbLanEndingNL.Size = new System.Drawing.Size(40, 17);
            this.chbLanEndingNL.TabIndex = 11;
            this.chbLanEndingNL.Text = "NL";
            this.chbLanEndingNL.UseVisualStyleBackColor = true;
            this.chbLanEndingNL.CheckedChanged += new System.EventHandler(this.chbLanEnding_CheckedChanged);
            // 
            // tbLanEnding
            // 
            this.tbLanEnding.Enabled = false;
            this.tbLanEnding.Location = new System.Drawing.Point(303, 78);
            this.tbLanEnding.Name = "tbLanEnding";
            this.tbLanEnding.Size = new System.Drawing.Size(39, 20);
            this.tbLanEnding.TabIndex = 10;
            // 
            // lbLanEnding
            // 
            this.lbLanEnding.AutoSize = true;
            this.lbLanEnding.Location = new System.Drawing.Point(6, 81);
            this.lbLanEnding.Name = "lbLanEnding";
            this.lbLanEnding.Size = new System.Drawing.Size(43, 13);
            this.lbLanEnding.TabIndex = 9;
            this.lbLanEnding.Text = "Ending:";
            // 
            // btLanSend
            // 
            this.btLanSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLanSend.Location = new System.Drawing.Point(522, 78);
            this.btLanSend.Name = "btLanSend";
            this.btLanSend.Size = new System.Drawing.Size(75, 23);
            this.btLanSend.TabIndex = 8;
            this.btLanSend.Text = "Send";
            this.btLanSend.UseVisualStyleBackColor = true;
            this.btLanSend.Click += new System.EventHandler(this.btLanSend_Click);
            // 
            // tbLanInput
            // 
            this.tbLanInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLanInput.Location = new System.Drawing.Point(6, 19);
            this.tbLanInput.Multiline = true;
            this.tbLanInput.Name = "tbLanInput";
            this.tbLanInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLanInput.Size = new System.Drawing.Size(591, 53);
            this.tbLanInput.TabIndex = 7;
            // 
            // lbLanError
            // 
            this.lbLanError.AutoSize = true;
            this.lbLanError.Location = new System.Drawing.Point(303, 3);
            this.lbLanError.Name = "lbLanError";
            this.lbLanError.Size = new System.Drawing.Size(32, 13);
            this.lbLanError.TabIndex = 14;
            this.lbLanError.Text = "Error:";
            // 
            // tbLanError
            // 
            this.tbLanError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLanError.Location = new System.Drawing.Point(303, 19);
            this.tbLanError.Multiline = true;
            this.tbLanError.Name = "tbLanError";
            this.tbLanError.ReadOnly = true;
            this.tbLanError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLanError.Size = new System.Drawing.Size(306, 89);
            this.tbLanError.TabIndex = 13;
            // 
            // btLanConnect
            // 
            this.btLanConnect.BackColor = System.Drawing.Color.Red;
            this.btLanConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLanConnect.Location = new System.Drawing.Point(222, 35);
            this.btLanConnect.Name = "btLanConnect";
            this.btLanConnect.Size = new System.Drawing.Size(75, 23);
            this.btLanConnect.TabIndex = 12;
            this.btLanConnect.Text = "Connect";
            this.btLanConnect.UseVisualStyleBackColor = false;
            this.btLanConnect.Click += new System.EventHandler(this.btLanConnect_Click);
            // 
            // btLanCreate
            // 
            this.btLanCreate.BackColor = System.Drawing.Color.Gray;
            this.btLanCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLanCreate.Location = new System.Drawing.Point(222, 6);
            this.btLanCreate.Name = "btLanCreate";
            this.btLanCreate.Size = new System.Drawing.Size(75, 23);
            this.btLanCreate.TabIndex = 11;
            this.btLanCreate.Text = "Create";
            this.btLanCreate.UseVisualStyleBackColor = false;
            this.btLanCreate.Click += new System.EventHandler(this.btLanCreate_Click);
            // 
            // gbHost
            // 
            this.gbHost.Controls.Add(this.lbLanTimeout);
            this.gbHost.Controls.Add(this.nudLanTimeout);
            this.gbHost.Controls.Add(this.lbLanPort);
            this.gbHost.Controls.Add(this.nudLanPort);
            this.gbHost.Controls.Add(this.tbLanIP);
            this.gbHost.Controls.Add(this.lbLanIP);
            this.gbHost.Location = new System.Drawing.Point(6, 6);
            this.gbHost.Name = "gbHost";
            this.gbHost.Size = new System.Drawing.Size(210, 102);
            this.gbHost.TabIndex = 3;
            this.gbHost.TabStop = false;
            this.gbHost.Text = "Host";
            // 
            // lbLanTimeout
            // 
            this.lbLanTimeout.AutoSize = true;
            this.lbLanTimeout.Location = new System.Drawing.Point(6, 73);
            this.lbLanTimeout.Name = "lbLanTimeout";
            this.lbLanTimeout.Size = new System.Drawing.Size(70, 13);
            this.lbLanTimeout.TabIndex = 7;
            this.lbLanTimeout.Text = "Timeout [ms]:";
            // 
            // nudLanTimeout
            // 
            this.nudLanTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudLanTimeout.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudLanTimeout.Location = new System.Drawing.Point(84, 71);
            this.nudLanTimeout.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.nudLanTimeout.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudLanTimeout.Name = "nudLanTimeout";
            this.nudLanTimeout.Size = new System.Drawing.Size(120, 20);
            this.nudLanTimeout.TabIndex = 6;
            this.nudLanTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLanTimeout.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // lbLanPort
            // 
            this.lbLanPort.AutoSize = true;
            this.lbLanPort.Location = new System.Drawing.Point(6, 47);
            this.lbLanPort.Name = "lbLanPort";
            this.lbLanPort.Size = new System.Drawing.Size(53, 13);
            this.lbLanPort.TabIndex = 3;
            this.lbLanPort.Text = "Host port:";
            // 
            // nudLanPort
            // 
            this.nudLanPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudLanPort.Location = new System.Drawing.Point(84, 45);
            this.nudLanPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudLanPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLanPort.Name = "nudLanPort";
            this.nudLanPort.Size = new System.Drawing.Size(120, 20);
            this.nudLanPort.TabIndex = 3;
            this.nudLanPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLanPort.Value = new decimal(new int[] {
            5555,
            0,
            0,
            0});
            // 
            // tbLanIP
            // 
            this.tbLanIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLanIP.Location = new System.Drawing.Point(84, 19);
            this.tbLanIP.Name = "tbLanIP";
            this.tbLanIP.Size = new System.Drawing.Size(120, 20);
            this.tbLanIP.TabIndex = 0;
            this.tbLanIP.Text = "10.1.1.101";
            this.tbLanIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbLanIP
            // 
            this.lbLanIP.AutoSize = true;
            this.lbLanIP.Location = new System.Drawing.Point(6, 22);
            this.lbLanIP.Name = "lbLanIP";
            this.lbLanIP.Size = new System.Drawing.Size(45, 13);
            this.lbLanIP.TabIndex = 1;
            this.lbLanIP.Text = "Host IP:";
            // 
            // DevicePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcDebug);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lbDebug);
            this.Controls.Add(this.pbDebug);
            this.Name = "DevicePanel";
            this.Size = new System.Drawing.Size(629, 493);
            ((System.ComponentModel.ISupportInitialize)(this.pbDebug)).EndInit();
            this.tcDebug.ResumeLayout(false);
            this.tpLan.ResumeLayout(false);
            this.tpLan.PerformLayout();
            this.gbCommands.ResumeLayout(false);
            this.gbCommands.PerformLayout();
            this.gbHost.ResumeLayout(false);
            this.gbHost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLanTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLanPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDebug;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbDebug;
        private System.Windows.Forms.TabControl tcDebug;
        private System.Windows.Forms.TabPage tpLan;
        private System.Windows.Forms.Button btLanDebug3;
        private System.Windows.Forms.Button btLanDebug2;
        private System.Windows.Forms.Button btLanDebug1;
        private System.Windows.Forms.GroupBox gbCommands;
        private System.Windows.Forms.TextBox tbLanOutput;
        private System.Windows.Forms.CheckBox chbLanRespond;
        private System.Windows.Forms.CheckBox chbLanStayConnected;
        private System.Windows.Forms.CheckBox chbLanEndingCustom;
        private System.Windows.Forms.CheckBox chbLanEndingCRNL;
        private System.Windows.Forms.CheckBox chbLanEndingNLCR;
        private System.Windows.Forms.CheckBox chbLanEndingCR;
        private System.Windows.Forms.CheckBox chbLanEndingNL;
        private System.Windows.Forms.TextBox tbLanEnding;
        private System.Windows.Forms.Label lbLanEnding;
        private System.Windows.Forms.Button btLanSend;
        private System.Windows.Forms.TextBox tbLanInput;
        private System.Windows.Forms.Label lbLanError;
        private System.Windows.Forms.TextBox tbLanError;
        private System.Windows.Forms.Button btLanConnect;
        private System.Windows.Forms.Button btLanCreate;
        private System.Windows.Forms.GroupBox gbHost;
        private System.Windows.Forms.Label lbLanTimeout;
        private System.Windows.Forms.NumericUpDown nudLanTimeout;
        private System.Windows.Forms.Label lbLanPort;
        private System.Windows.Forms.NumericUpDown nudLanPort;
        private System.Windows.Forms.TextBox tbLanIP;
        private System.Windows.Forms.Label lbLanIP;
    }
}
