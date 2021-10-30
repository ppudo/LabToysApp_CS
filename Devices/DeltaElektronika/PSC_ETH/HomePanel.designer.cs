
namespace DeltaElektronika.PSC_ETH
{
    partial class HomePanel
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
            this.nudVoltage = new System.Windows.Forms.NumericUpDown();
            this.tbMeasuredVoltage = new System.Windows.Forms.TextBox();
            this.nudCurrent = new System.Windows.Forms.NumericUpDown();
            this.tbMeasuredCurrent = new System.Windows.Forms.TextBox();
            this.btOutput = new System.Windows.Forms.Button();
            this.gbVoltage = new System.Windows.Forms.GroupBox();
            this.gbCurrent = new System.Windows.Forms.GroupBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.gbInputs = new System.Windows.Forms.GroupBox();
            this.lbOutputH = new System.Windows.Forms.Label();
            this.tbOutputH = new System.Windows.Forms.TextBox();
            this.lbOutputG = new System.Windows.Forms.Label();
            this.tbOutputG = new System.Windows.Forms.TextBox();
            this.lbInputF = new System.Windows.Forms.Label();
            this.tbInputF = new System.Windows.Forms.TextBox();
            this.lbInputE = new System.Windows.Forms.Label();
            this.tbInputE = new System.Windows.Forms.TextBox();
            this.lbInputD = new System.Windows.Forms.Label();
            this.tbInputD = new System.Windows.Forms.TextBox();
            this.lbOutputC = new System.Windows.Forms.Label();
            this.tbOutputC = new System.Windows.Forms.TextBox();
            this.lbOutputB = new System.Windows.Forms.Label();
            this.tbOutputB = new System.Windows.Forms.TextBox();
            this.lbInputA = new System.Windows.Forms.Label();
            this.tbInputA = new System.Windows.Forms.TextBox();
            this.gbOutputs = new System.Windows.Forms.GroupBox();
            this.btOutputF = new System.Windows.Forms.Button();
            this.btOutputE = new System.Windows.Forms.Button();
            this.btOutputD = new System.Windows.Forms.Button();
            this.btOutputC = new System.Windows.Forms.Button();
            this.btOutputB = new System.Windows.Forms.Button();
            this.btOutputA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btRemoteVoltage = new System.Windows.Forms.Button();
            this.btRemoteCurrent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrent)).BeginInit();
            this.gbVoltage.SuspendLayout();
            this.gbCurrent.SuspendLayout();
            this.gbInputs.SuspendLayout();
            this.gbOutputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTitle.Location = new System.Drawing.Point(3, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(83, 33);
            this.lbTitle.TabIndex = 16;
            this.lbTitle.Text = "Main";
            // 
            // nudVoltage
            // 
            this.nudVoltage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudVoltage.DecimalPlaces = 4;
            this.nudVoltage.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudVoltage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudVoltage.Location = new System.Drawing.Point(28, 19);
            this.nudVoltage.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nudVoltage.Name = "nudVoltage";
            this.nudVoltage.Size = new System.Drawing.Size(146, 39);
            this.nudVoltage.TabIndex = 17;
            this.nudVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudVoltage.Value = new decimal(new int[] {
            120,
            0,
            0,
            65536});
            this.nudVoltage.ValueChanged += new System.EventHandler(this.nudVoltage_ValueChanged);
            // 
            // tbMeasuredVoltage
            // 
            this.tbMeasuredVoltage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMeasuredVoltage.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbMeasuredVoltage.Location = new System.Drawing.Point(73, 64);
            this.tbMeasuredVoltage.Name = "tbMeasuredVoltage";
            this.tbMeasuredVoltage.ReadOnly = true;
            this.tbMeasuredVoltage.Size = new System.Drawing.Size(101, 26);
            this.tbMeasuredVoltage.TabIndex = 19;
            this.tbMeasuredVoltage.Text = "XX.XXXX V";
            this.tbMeasuredVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudCurrent
            // 
            this.nudCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCurrent.DecimalPlaces = 4;
            this.nudCurrent.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudCurrent.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudCurrent.Location = new System.Drawing.Point(28, 19);
            this.nudCurrent.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            65536});
            this.nudCurrent.Name = "nudCurrent";
            this.nudCurrent.Size = new System.Drawing.Size(146, 39);
            this.nudCurrent.TabIndex = 20;
            this.nudCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCurrent.Value = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            this.nudCurrent.ValueChanged += new System.EventHandler(this.nudCurrent_ValueChanged);
            // 
            // tbMeasuredCurrent
            // 
            this.tbMeasuredCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMeasuredCurrent.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbMeasuredCurrent.Location = new System.Drawing.Point(73, 64);
            this.tbMeasuredCurrent.Name = "tbMeasuredCurrent";
            this.tbMeasuredCurrent.ReadOnly = true;
            this.tbMeasuredCurrent.Size = new System.Drawing.Size(101, 26);
            this.tbMeasuredCurrent.TabIndex = 22;
            this.tbMeasuredCurrent.Text = "XX.XXXX A";
            this.tbMeasuredCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btOutput
            // 
            this.btOutput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOutput.Location = new System.Drawing.Point(294, 142);
            this.btOutput.Name = "btOutput";
            this.btOutput.Size = new System.Drawing.Size(75, 23);
            this.btOutput.TabIndex = 23;
            this.btOutput.Text = "Output OFF";
            this.btOutput.UseVisualStyleBackColor = false;
            this.btOutput.Click += new System.EventHandler(this.btOutput_Click);
            // 
            // gbVoltage
            // 
            this.gbVoltage.Controls.Add(this.btRemoteVoltage);
            this.gbVoltage.Controls.Add(this.nudVoltage);
            this.gbVoltage.Controls.Add(this.tbMeasuredVoltage);
            this.gbVoltage.Location = new System.Drawing.Point(3, 36);
            this.gbVoltage.Name = "gbVoltage";
            this.gbVoltage.Size = new System.Drawing.Size(180, 100);
            this.gbVoltage.TabIndex = 24;
            this.gbVoltage.TabStop = false;
            this.gbVoltage.Text = "Voltage";
            // 
            // gbCurrent
            // 
            this.gbCurrent.Controls.Add(this.btRemoteCurrent);
            this.gbCurrent.Controls.Add(this.nudCurrent);
            this.gbCurrent.Controls.Add(this.tbMeasuredCurrent);
            this.gbCurrent.Location = new System.Drawing.Point(189, 36);
            this.gbCurrent.Name = "gbCurrent";
            this.gbCurrent.Size = new System.Drawing.Size(180, 100);
            this.gbCurrent.TabIndex = 25;
            this.gbCurrent.TabStop = false;
            this.gbCurrent.Text = "Current";
            // 
            // btRefresh
            // 
            this.btRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRefresh.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefresh.Location = new System.Drawing.Point(451, 3);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(107, 23);
            this.btRefresh.TabIndex = 26;
            this.btRefresh.Text = "Refresh disabled";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // gbInputs
            // 
            this.gbInputs.Controls.Add(this.lbOutputH);
            this.gbInputs.Controls.Add(this.tbOutputH);
            this.gbInputs.Controls.Add(this.lbOutputG);
            this.gbInputs.Controls.Add(this.tbOutputG);
            this.gbInputs.Controls.Add(this.lbInputF);
            this.gbInputs.Controls.Add(this.tbInputF);
            this.gbInputs.Controls.Add(this.lbInputE);
            this.gbInputs.Controls.Add(this.tbInputE);
            this.gbInputs.Controls.Add(this.lbInputD);
            this.gbInputs.Controls.Add(this.tbInputD);
            this.gbInputs.Controls.Add(this.lbOutputC);
            this.gbInputs.Controls.Add(this.tbOutputC);
            this.gbInputs.Controls.Add(this.lbOutputB);
            this.gbInputs.Controls.Add(this.tbOutputB);
            this.gbInputs.Controls.Add(this.lbInputA);
            this.gbInputs.Controls.Add(this.tbInputA);
            this.gbInputs.Location = new System.Drawing.Point(3, 171);
            this.gbInputs.Name = "gbInputs";
            this.gbInputs.Size = new System.Drawing.Size(244, 68);
            this.gbInputs.TabIndex = 27;
            this.gbInputs.TabStop = false;
            this.gbInputs.Text = "Inputs";
            // 
            // lbOutputH
            // 
            this.lbOutputH.AutoSize = true;
            this.lbOutputH.Location = new System.Drawing.Point(209, 16);
            this.lbOutputH.Name = "lbOutputH";
            this.lbOutputH.Size = new System.Drawing.Size(15, 13);
            this.lbOutputH.TabIndex = 22;
            this.lbOutputH.Text = "H";
            // 
            // tbOutputH
            // 
            this.tbOutputH.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbOutputH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOutputH.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbOutputH.Location = new System.Drawing.Point(209, 32);
            this.tbOutputH.Name = "tbOutputH";
            this.tbOutputH.ReadOnly = true;
            this.tbOutputH.Size = new System.Drawing.Size(23, 23);
            this.tbOutputH.TabIndex = 21;
            this.tbOutputH.Text = "0";
            this.tbOutputH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbOutputG
            // 
            this.lbOutputG.AutoSize = true;
            this.lbOutputG.Location = new System.Drawing.Point(180, 16);
            this.lbOutputG.Name = "lbOutputG";
            this.lbOutputG.Size = new System.Drawing.Size(15, 13);
            this.lbOutputG.TabIndex = 20;
            this.lbOutputG.Text = "G";
            // 
            // tbOutputG
            // 
            this.tbOutputG.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbOutputG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOutputG.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbOutputG.Location = new System.Drawing.Point(180, 32);
            this.tbOutputG.Name = "tbOutputG";
            this.tbOutputG.ReadOnly = true;
            this.tbOutputG.Size = new System.Drawing.Size(23, 23);
            this.tbOutputG.TabIndex = 19;
            this.tbOutputG.Text = "0";
            this.tbOutputG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbInputF
            // 
            this.lbInputF.AutoSize = true;
            this.lbInputF.Location = new System.Drawing.Point(151, 16);
            this.lbInputF.Name = "lbInputF";
            this.lbInputF.Size = new System.Drawing.Size(13, 13);
            this.lbInputF.TabIndex = 18;
            this.lbInputF.Text = "F";
            // 
            // tbInputF
            // 
            this.tbInputF.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbInputF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInputF.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbInputF.Location = new System.Drawing.Point(151, 32);
            this.tbInputF.Name = "tbInputF";
            this.tbInputF.ReadOnly = true;
            this.tbInputF.Size = new System.Drawing.Size(23, 23);
            this.tbInputF.TabIndex = 17;
            this.tbInputF.Text = "0";
            this.tbInputF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbInputE
            // 
            this.lbInputE.AutoSize = true;
            this.lbInputE.Location = new System.Drawing.Point(122, 16);
            this.lbInputE.Name = "lbInputE";
            this.lbInputE.Size = new System.Drawing.Size(14, 13);
            this.lbInputE.TabIndex = 16;
            this.lbInputE.Text = "E";
            // 
            // tbInputE
            // 
            this.tbInputE.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbInputE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInputE.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbInputE.Location = new System.Drawing.Point(122, 32);
            this.tbInputE.Name = "tbInputE";
            this.tbInputE.ReadOnly = true;
            this.tbInputE.Size = new System.Drawing.Size(23, 23);
            this.tbInputE.TabIndex = 15;
            this.tbInputE.Text = "0";
            this.tbInputE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbInputD
            // 
            this.lbInputD.AutoSize = true;
            this.lbInputD.Location = new System.Drawing.Point(93, 16);
            this.lbInputD.Name = "lbInputD";
            this.lbInputD.Size = new System.Drawing.Size(15, 13);
            this.lbInputD.TabIndex = 14;
            this.lbInputD.Text = "D";
            // 
            // tbInputD
            // 
            this.tbInputD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbInputD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInputD.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbInputD.Location = new System.Drawing.Point(93, 32);
            this.tbInputD.Name = "tbInputD";
            this.tbInputD.ReadOnly = true;
            this.tbInputD.Size = new System.Drawing.Size(23, 23);
            this.tbInputD.TabIndex = 13;
            this.tbInputD.Text = "0";
            this.tbInputD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbOutputC
            // 
            this.lbOutputC.AutoSize = true;
            this.lbOutputC.Location = new System.Drawing.Point(64, 16);
            this.lbOutputC.Name = "lbOutputC";
            this.lbOutputC.Size = new System.Drawing.Size(14, 13);
            this.lbOutputC.TabIndex = 12;
            this.lbOutputC.Text = "C";
            // 
            // tbOutputC
            // 
            this.tbOutputC.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbOutputC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOutputC.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbOutputC.Location = new System.Drawing.Point(64, 32);
            this.tbOutputC.Name = "tbOutputC";
            this.tbOutputC.ReadOnly = true;
            this.tbOutputC.Size = new System.Drawing.Size(23, 23);
            this.tbOutputC.TabIndex = 11;
            this.tbOutputC.Text = "0";
            this.tbOutputC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbOutputB
            // 
            this.lbOutputB.AutoSize = true;
            this.lbOutputB.Location = new System.Drawing.Point(35, 16);
            this.lbOutputB.Name = "lbOutputB";
            this.lbOutputB.Size = new System.Drawing.Size(14, 13);
            this.lbOutputB.TabIndex = 10;
            this.lbOutputB.Text = "B";
            // 
            // tbOutputB
            // 
            this.tbOutputB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbOutputB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOutputB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbOutputB.Location = new System.Drawing.Point(35, 32);
            this.tbOutputB.Name = "tbOutputB";
            this.tbOutputB.ReadOnly = true;
            this.tbOutputB.Size = new System.Drawing.Size(23, 23);
            this.tbOutputB.TabIndex = 9;
            this.tbOutputB.Text = "0";
            this.tbOutputB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbInputA
            // 
            this.lbInputA.AutoSize = true;
            this.lbInputA.Location = new System.Drawing.Point(6, 16);
            this.lbInputA.Name = "lbInputA";
            this.lbInputA.Size = new System.Drawing.Size(14, 13);
            this.lbInputA.TabIndex = 8;
            this.lbInputA.Text = "A";
            // 
            // tbInputA
            // 
            this.tbInputA.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbInputA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInputA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbInputA.Location = new System.Drawing.Point(6, 32);
            this.tbInputA.Name = "tbInputA";
            this.tbInputA.ReadOnly = true;
            this.tbInputA.Size = new System.Drawing.Size(23, 23);
            this.tbInputA.TabIndex = 0;
            this.tbInputA.Text = "0";
            this.tbInputA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbOutputs
            // 
            this.gbOutputs.Controls.Add(this.btOutputF);
            this.gbOutputs.Controls.Add(this.btOutputE);
            this.gbOutputs.Controls.Add(this.btOutputD);
            this.gbOutputs.Controls.Add(this.btOutputC);
            this.gbOutputs.Controls.Add(this.btOutputB);
            this.gbOutputs.Controls.Add(this.btOutputA);
            this.gbOutputs.Controls.Add(this.label1);
            this.gbOutputs.Controls.Add(this.label2);
            this.gbOutputs.Controls.Add(this.label3);
            this.gbOutputs.Controls.Add(this.label4);
            this.gbOutputs.Controls.Add(this.label5);
            this.gbOutputs.Controls.Add(this.label6);
            this.gbOutputs.Location = new System.Drawing.Point(3, 245);
            this.gbOutputs.Name = "gbOutputs";
            this.gbOutputs.Size = new System.Drawing.Size(184, 65);
            this.gbOutputs.TabIndex = 28;
            this.gbOutputs.TabStop = false;
            this.gbOutputs.Text = "Outputs";
            // 
            // btOutputF
            // 
            this.btOutputF.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btOutputF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOutputF.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btOutputF.Location = new System.Drawing.Point(151, 32);
            this.btOutputF.Name = "btOutputF";
            this.btOutputF.Size = new System.Drawing.Size(23, 23);
            this.btOutputF.TabIndex = 30;
            this.btOutputF.Tag = "5";
            this.btOutputF.Text = "0";
            this.btOutputF.UseVisualStyleBackColor = false;
            this.btOutputF.Click += new System.EventHandler(this.btOutputX_Click);
            // 
            // btOutputE
            // 
            this.btOutputE.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btOutputE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOutputE.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btOutputE.Location = new System.Drawing.Point(122, 32);
            this.btOutputE.Name = "btOutputE";
            this.btOutputE.Size = new System.Drawing.Size(23, 23);
            this.btOutputE.TabIndex = 29;
            this.btOutputE.Tag = "4";
            this.btOutputE.Text = "0";
            this.btOutputE.UseVisualStyleBackColor = false;
            this.btOutputE.Click += new System.EventHandler(this.btOutputX_Click);
            // 
            // btOutputD
            // 
            this.btOutputD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btOutputD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOutputD.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btOutputD.Location = new System.Drawing.Point(93, 32);
            this.btOutputD.Name = "btOutputD";
            this.btOutputD.Size = new System.Drawing.Size(23, 23);
            this.btOutputD.TabIndex = 28;
            this.btOutputD.Tag = "4";
            this.btOutputD.Text = "0";
            this.btOutputD.UseVisualStyleBackColor = false;
            this.btOutputD.Click += new System.EventHandler(this.btOutputX_Click);
            // 
            // btOutputC
            // 
            this.btOutputC.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btOutputC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOutputC.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btOutputC.Location = new System.Drawing.Point(64, 32);
            this.btOutputC.Name = "btOutputC";
            this.btOutputC.Size = new System.Drawing.Size(23, 23);
            this.btOutputC.TabIndex = 27;
            this.btOutputC.Tag = "2";
            this.btOutputC.Text = "0";
            this.btOutputC.UseVisualStyleBackColor = false;
            this.btOutputC.Click += new System.EventHandler(this.btOutputX_Click);
            // 
            // btOutputB
            // 
            this.btOutputB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btOutputB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOutputB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btOutputB.Location = new System.Drawing.Point(35, 32);
            this.btOutputB.Name = "btOutputB";
            this.btOutputB.Size = new System.Drawing.Size(23, 23);
            this.btOutputB.TabIndex = 26;
            this.btOutputB.Tag = "1";
            this.btOutputB.Text = "0";
            this.btOutputB.UseVisualStyleBackColor = false;
            this.btOutputB.Click += new System.EventHandler(this.btOutputX_Click);
            // 
            // btOutputA
            // 
            this.btOutputA.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btOutputA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOutputA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btOutputA.Location = new System.Drawing.Point(6, 32);
            this.btOutputA.Name = "btOutputA";
            this.btOutputA.Size = new System.Drawing.Size(23, 23);
            this.btOutputA.TabIndex = 25;
            this.btOutputA.Tag = "0";
            this.btOutputA.Text = "0";
            this.btOutputA.UseVisualStyleBackColor = false;
            this.btOutputA.Click += new System.EventHandler(this.btOutputX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "F";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "E";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "A";
            // 
            // btRemoteVoltage
            // 
            this.btRemoteVoltage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btRemoteVoltage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btRemoteVoltage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoteVoltage.Location = new System.Drawing.Point(6, 71);
            this.btRemoteVoltage.Name = "btRemoteVoltage";
            this.btRemoteVoltage.Size = new System.Drawing.Size(61, 23);
            this.btRemoteVoltage.TabIndex = 29;
            this.btRemoteVoltage.Text = "Local";
            this.btRemoteVoltage.UseVisualStyleBackColor = false;
            this.btRemoteVoltage.Click += new System.EventHandler(this.btRemoteVoltage_Click);
            // 
            // btRemoteCurrent
            // 
            this.btRemoteCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btRemoteCurrent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btRemoteCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoteCurrent.Location = new System.Drawing.Point(6, 71);
            this.btRemoteCurrent.Name = "btRemoteCurrent";
            this.btRemoteCurrent.Size = new System.Drawing.Size(61, 23);
            this.btRemoteCurrent.TabIndex = 30;
            this.btRemoteCurrent.Text = "Local";
            this.btRemoteCurrent.UseVisualStyleBackColor = false;
            this.btRemoteCurrent.Click += new System.EventHandler(this.btRemoteCurrent_Click);
            // 
            // HomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbOutputs);
            this.Controls.Add(this.gbInputs);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.gbCurrent);
            this.Controls.Add(this.gbVoltage);
            this.Controls.Add(this.btOutput);
            this.Controls.Add(this.lbTitle);
            this.Name = "HomePanel";
            this.Size = new System.Drawing.Size(561, 316);
            ((System.ComponentModel.ISupportInitialize)(this.nudVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrent)).EndInit();
            this.gbVoltage.ResumeLayout(false);
            this.gbVoltage.PerformLayout();
            this.gbCurrent.ResumeLayout(false);
            this.gbCurrent.PerformLayout();
            this.gbInputs.ResumeLayout(false);
            this.gbInputs.PerformLayout();
            this.gbOutputs.ResumeLayout(false);
            this.gbOutputs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.NumericUpDown nudVoltage;
        private System.Windows.Forms.TextBox tbMeasuredVoltage;
        private System.Windows.Forms.NumericUpDown nudCurrent;
        private System.Windows.Forms.TextBox tbMeasuredCurrent;
        private System.Windows.Forms.Button btOutput;
        private System.Windows.Forms.GroupBox gbVoltage;
        private System.Windows.Forms.GroupBox gbCurrent;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.GroupBox gbInputs;
        private System.Windows.Forms.TextBox tbInputA;
        private System.Windows.Forms.Label lbInputA;
        private System.Windows.Forms.Label lbOutputH;
        private System.Windows.Forms.TextBox tbOutputH;
        private System.Windows.Forms.Label lbOutputG;
        private System.Windows.Forms.TextBox tbOutputG;
        private System.Windows.Forms.Label lbInputF;
        private System.Windows.Forms.TextBox tbInputF;
        private System.Windows.Forms.Label lbInputE;
        private System.Windows.Forms.TextBox tbInputE;
        private System.Windows.Forms.Label lbInputD;
        private System.Windows.Forms.TextBox tbInputD;
        private System.Windows.Forms.Label lbOutputC;
        private System.Windows.Forms.TextBox tbOutputC;
        private System.Windows.Forms.Label lbOutputB;
        private System.Windows.Forms.TextBox tbOutputB;
        private System.Windows.Forms.GroupBox gbOutputs;
        private System.Windows.Forms.Button btOutputF;
        private System.Windows.Forms.Button btOutputE;
        private System.Windows.Forms.Button btOutputD;
        private System.Windows.Forms.Button btOutputC;
        private System.Windows.Forms.Button btOutputB;
        private System.Windows.Forms.Button btOutputA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btRemoteVoltage;
        private System.Windows.Forms.Button btRemoteCurrent;
    }
}
