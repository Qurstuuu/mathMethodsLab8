namespace lab8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonFlipCoin = new System.Windows.Forms.Button();
            this.groupBoxCoinflip = new System.Windows.Forms.GroupBox();
            this.pictureBoxCoin = new System.Windows.Forms.PictureBox();
            this.groupBox8Ball = new System.Windows.Forms.GroupBox();
            this.label8Ball = new System.Windows.Forms.Label();
            this.button8Ball = new System.Windows.Forms.Button();
            this.groupBoxEvent = new System.Windows.Forms.GroupBox();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.numericUpDownTrials = new System.Windows.Forms.NumericUpDown();
            this.labelTrials = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.errorProviderEvents = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxCoinflip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin)).BeginInit();
            this.groupBox8Ball.SuspendLayout();
            this.groupBoxEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFlipCoin
            // 
            this.buttonFlipCoin.Location = new System.Drawing.Point(17, 19);
            this.buttonFlipCoin.Name = "buttonFlipCoin";
            this.buttonFlipCoin.Size = new System.Drawing.Size(89, 32);
            this.buttonFlipCoin.TabIndex = 0;
            this.buttonFlipCoin.Text = "Flip Coin";
            this.buttonFlipCoin.UseVisualStyleBackColor = true;
            this.buttonFlipCoin.Click += new System.EventHandler(this.buttonFlipCoin_Click);
            // 
            // groupBoxCoinflip
            // 
            this.groupBoxCoinflip.Controls.Add(this.pictureBoxCoin);
            this.groupBoxCoinflip.Controls.Add(this.buttonFlipCoin);
            this.groupBoxCoinflip.Location = new System.Drawing.Point(13, 12);
            this.groupBoxCoinflip.Name = "groupBoxCoinflip";
            this.groupBoxCoinflip.Size = new System.Drawing.Size(125, 175);
            this.groupBoxCoinflip.TabIndex = 1;
            this.groupBoxCoinflip.TabStop = false;
            this.groupBoxCoinflip.Text = "50/50";
            // 
            // pictureBoxCoin
            // 
            this.pictureBoxCoin.Location = new System.Drawing.Point(17, 67);
            this.pictureBoxCoin.Name = "pictureBoxCoin";
            this.pictureBoxCoin.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxCoin.TabIndex = 1;
            this.pictureBoxCoin.TabStop = false;
            // 
            // groupBox8Ball
            // 
            this.groupBox8Ball.Controls.Add(this.label8Ball);
            this.groupBox8Ball.Controls.Add(this.button8Ball);
            this.groupBox8Ball.Location = new System.Drawing.Point(155, 12);
            this.groupBox8Ball.Name = "groupBox8Ball";
            this.groupBox8Ball.Size = new System.Drawing.Size(180, 99);
            this.groupBox8Ball.TabIndex = 2;
            this.groupBox8Ball.TabStop = false;
            this.groupBox8Ball.Text = "Magic 8-Ball";
            // 
            // label8Ball
            // 
            this.label8Ball.AutoSize = true;
            this.label8Ball.Location = new System.Drawing.Point(17, 67);
            this.label8Ball.Name = "label8Ball";
            this.label8Ball.Size = new System.Drawing.Size(0, 13);
            this.label8Ball.TabIndex = 1;
            // 
            // button8Ball
            // 
            this.button8Ball.Location = new System.Drawing.Point(20, 19);
            this.button8Ball.Name = "button8Ball";
            this.button8Ball.Size = new System.Drawing.Size(85, 32);
            this.button8Ball.TabIndex = 0;
            this.button8Ball.Text = "Tell me";
            this.button8Ball.UseVisualStyleBackColor = true;
            this.button8Ball.Click += new System.EventHandler(this.button8Ball_Click);
            // 
            // groupBoxEvent
            // 
            this.groupBoxEvent.Controls.Add(this.buttonEvents);
            this.groupBoxEvent.Controls.Add(this.numericUpDownTrials);
            this.groupBoxEvent.Controls.Add(this.labelTrials);
            this.groupBoxEvent.Controls.Add(this.numericUpDown5);
            this.groupBoxEvent.Controls.Add(this.numericUpDown4);
            this.groupBoxEvent.Controls.Add(this.numericUpDown3);
            this.groupBoxEvent.Controls.Add(this.numericUpDown2);
            this.groupBoxEvent.Controls.Add(this.numericUpDown1);
            this.groupBoxEvent.Controls.Add(this.label5);
            this.groupBoxEvent.Controls.Add(this.label4);
            this.groupBoxEvent.Controls.Add(this.label3);
            this.groupBoxEvent.Controls.Add(this.label2);
            this.groupBoxEvent.Controls.Add(this.label1);
            this.groupBoxEvent.Controls.Add(this.chart1);
            this.groupBoxEvent.Location = new System.Drawing.Point(355, 12);
            this.groupBoxEvent.Name = "groupBoxEvent";
            this.groupBoxEvent.Size = new System.Drawing.Size(433, 426);
            this.groupBoxEvent.TabIndex = 3;
            this.groupBoxEvent.TabStop = false;
            this.groupBoxEvent.Text = "Group of events";
            // 
            // buttonEvents
            // 
            this.buttonEvents.Location = new System.Drawing.Point(215, 56);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(100, 35);
            this.buttonEvents.TabIndex = 13;
            this.buttonEvents.Text = "Start";
            this.buttonEvents.UseVisualStyleBackColor = true;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // numericUpDownTrials
            // 
            this.numericUpDownTrials.Location = new System.Drawing.Point(298, 27);
            this.numericUpDownTrials.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownTrials.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTrials.Name = "numericUpDownTrials";
            this.numericUpDownTrials.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTrials.TabIndex = 12;
            this.numericUpDownTrials.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelTrials
            // 
            this.labelTrials.AutoSize = true;
            this.labelTrials.Location = new System.Drawing.Point(212, 29);
            this.labelTrials.Name = "labelTrials";
            this.labelTrials.Size = new System.Drawing.Size(80, 13);
            this.labelTrials.TabIndex = 11;
            this.labelTrials.Text = "Number of trials";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DecimalPlaces = 3;
            this.numericUpDown5.Enabled = false;
            this.numericUpDown5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown5.InterceptArrowKeys = false;
            this.numericUpDown5.Location = new System.Drawing.Point(56, 142);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.ReadOnly = true;
            this.numericUpDown5.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown5.TabIndex = 10;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 3;
            this.numericUpDown4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown4.Location = new System.Drawing.Point(57, 111);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown4.TabIndex = 9;
            this.numericUpDown4.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 3;
            this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown3.Location = new System.Drawing.Point(57, 82);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 8;
            this.numericUpDown3.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 3;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown2.Location = new System.Drawing.Point(57, 54);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 3;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(57, 27);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Prob 5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prob 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prob 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prob 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prob1";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 168);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(421, 252);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "дф";
            // 
            // errorProviderEvents
            // 
            this.errorProviderEvents.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxEvent);
            this.Controls.Add(this.groupBox8Ball);
            this.Controls.Add(this.groupBoxCoinflip);
            this.Name = "Form1";
            this.Text = "Random Generators";
            this.groupBoxCoinflip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin)).EndInit();
            this.groupBox8Ball.ResumeLayout(false);
            this.groupBox8Ball.PerformLayout();
            this.groupBoxEvent.ResumeLayout(false);
            this.groupBoxEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFlipCoin;
        private System.Windows.Forms.GroupBox groupBoxCoinflip;
        private System.Windows.Forms.PictureBox pictureBoxCoin;
        private System.Windows.Forms.GroupBox groupBox8Ball;
        private System.Windows.Forms.Button button8Ball;
        private System.Windows.Forms.Label label8Ball;
        private System.Windows.Forms.GroupBox groupBoxEvent;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.NumericUpDown numericUpDownTrials;
        private System.Windows.Forms.Label labelTrials;
        private System.Windows.Forms.ErrorProvider errorProviderEvents;
    }
}

