
namespace CTS.ASCII_Proto_ETH
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbTemp = new System.Windows.Forms.GroupBox();
            this.nudTemp = new System.Windows.Forms.NumericUpDown();
            this.tbMeasuredTemp = new System.Windows.Forms.TextBox();
            this.gbHumidity = new System.Windows.Forms.GroupBox();
            this.nudHumidity = new System.Windows.Forms.NumericUpDown();
            this.tbHumidity = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.lbMemories = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemp)).BeginInit();
            this.gbHumidity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.lbTitle.Text = "Main";
            // 
            // gbTemp
            // 
            this.gbTemp.Controls.Add(this.nudTemp);
            this.gbTemp.Controls.Add(this.tbMeasuredTemp);
            this.gbTemp.Location = new System.Drawing.Point(3, 36);
            this.gbTemp.Name = "gbTemp";
            this.gbTemp.Size = new System.Drawing.Size(180, 100);
            this.gbTemp.TabIndex = 25;
            this.gbTemp.TabStop = false;
            this.gbTemp.Text = "Temperature";
            // 
            // nudTemp
            // 
            this.nudTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTemp.DecimalPlaces = 1;
            this.nudTemp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudTemp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudTemp.Location = new System.Drawing.Point(74, 64);
            this.nudTemp.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudTemp.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.nudTemp.Name = "nudTemp";
            this.nudTemp.Size = new System.Drawing.Size(100, 26);
            this.nudTemp.TabIndex = 17;
            this.nudTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTemp.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudTemp.ValueChanged += new System.EventHandler(this.nudTemp_ValueChanged);
            // 
            // tbMeasuredTemp
            // 
            this.tbMeasuredTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMeasuredTemp.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbMeasuredTemp.Location = new System.Drawing.Point(24, 19);
            this.tbMeasuredTemp.Name = "tbMeasuredTemp";
            this.tbMeasuredTemp.ReadOnly = true;
            this.tbMeasuredTemp.Size = new System.Drawing.Size(150, 39);
            this.tbMeasuredTemp.TabIndex = 19;
            this.tbMeasuredTemp.Text = "XX.X °C";
            this.tbMeasuredTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbHumidity
            // 
            this.gbHumidity.Controls.Add(this.nudHumidity);
            this.gbHumidity.Controls.Add(this.tbHumidity);
            this.gbHumidity.Enabled = false;
            this.gbHumidity.Location = new System.Drawing.Point(189, 36);
            this.gbHumidity.Name = "gbHumidity";
            this.gbHumidity.Size = new System.Drawing.Size(180, 100);
            this.gbHumidity.TabIndex = 26;
            this.gbHumidity.TabStop = false;
            this.gbHumidity.Text = "Humidity";
            // 
            // nudHumidity
            // 
            this.nudHumidity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudHumidity.DecimalPlaces = 1;
            this.nudHumidity.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudHumidity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudHumidity.Location = new System.Drawing.Point(74, 64);
            this.nudHumidity.Name = "nudHumidity";
            this.nudHumidity.Size = new System.Drawing.Size(100, 26);
            this.nudHumidity.TabIndex = 17;
            this.nudHumidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudHumidity.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // tbHumidity
            // 
            this.tbHumidity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHumidity.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbHumidity.Location = new System.Drawing.Point(24, 19);
            this.tbHumidity.Name = "tbHumidity";
            this.tbHumidity.ReadOnly = true;
            this.tbHumidity.Size = new System.Drawing.Size(150, 39);
            this.tbHumidity.TabIndex = 19;
            this.tbHumidity.Text = "XX.X %";
            this.tbHumidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStart.Location = new System.Drawing.Point(294, 142);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 27;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lbMemories
            // 
            this.lbMemories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMemories.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbMemories.FormattingEnabled = true;
            this.lbMemories.ItemHeight = 19;
            this.lbMemories.Location = new System.Drawing.Point(375, 36);
            this.lbMemories.Name = "lbMemories";
            this.lbMemories.Size = new System.Drawing.Size(238, 118);
            this.lbMemories.TabIndex = 28;
            this.lbMemories.SelectedIndexChanged += new System.EventHandler(this.lbMemories_SelectedIndexChanged);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 171);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(610, 313);
            this.chart1.TabIndex = 29;
            this.chart1.Text = "chart1";
            // 
            // HomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lbMemories);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.gbHumidity);
            this.Controls.Add(this.gbTemp);
            this.Controls.Add(this.lbTitle);
            this.Name = "HomePanel";
            this.Size = new System.Drawing.Size(616, 490);
            this.gbTemp.ResumeLayout(false);
            this.gbTemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemp)).EndInit();
            this.gbHumidity.ResumeLayout(false);
            this.gbHumidity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox gbTemp;
        private System.Windows.Forms.NumericUpDown nudTemp;
        private System.Windows.Forms.TextBox tbMeasuredTemp;
        private System.Windows.Forms.GroupBox gbHumidity;
        private System.Windows.Forms.NumericUpDown nudHumidity;
        private System.Windows.Forms.TextBox tbHumidity;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.ListBox lbMemories;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
