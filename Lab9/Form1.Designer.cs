
namespace Lab9
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.prob1 = new System.Windows.Forms.NumericUpDown();
            this.prob2 = new System.Windows.Forms.NumericUpDown();
            this.prob3 = new System.Windows.Forms.NumericUpDown();
            this.prob4 = new System.Windows.Forms.NumericUpDown();
            this.prob5 = new System.Windows.Forms.NumericUpDown();
            this.daysNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(15, 15);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(491, 319);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // prob1
            // 
            this.prob1.DecimalPlaces = 4;
            this.prob1.Location = new System.Drawing.Point(629, 66);
            this.prob1.Name = "prob1";
            this.prob1.Size = new System.Drawing.Size(106, 22);
            this.prob1.TabIndex = 1;
            this.prob1.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // prob2
            // 
            this.prob2.DecimalPlaces = 4;
            this.prob2.Location = new System.Drawing.Point(629, 108);
            this.prob2.Name = "prob2";
            this.prob2.Size = new System.Drawing.Size(106, 22);
            this.prob2.TabIndex = 2;
            this.prob2.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // prob3
            // 
            this.prob3.DecimalPlaces = 4;
            this.prob3.Location = new System.Drawing.Point(629, 162);
            this.prob3.Name = "prob3";
            this.prob3.Size = new System.Drawing.Size(106, 22);
            this.prob3.TabIndex = 3;
            this.prob3.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // prob4
            // 
            this.prob4.DecimalPlaces = 4;
            this.prob4.Location = new System.Drawing.Point(629, 216);
            this.prob4.Name = "prob4";
            this.prob4.Size = new System.Drawing.Size(106, 22);
            this.prob4.TabIndex = 4;
            this.prob4.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // prob5
            // 
            this.prob5.DecimalPlaces = 4;
            this.prob5.Location = new System.Drawing.Point(629, 271);
            this.prob5.Name = "prob5";
            this.prob5.Size = new System.Drawing.Size(106, 22);
            this.prob5.TabIndex = 5;
            this.prob5.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // daysNumeric
            // 
            this.daysNumeric.Location = new System.Drawing.Point(629, 379);
            this.daysNumeric.Name = "daysNumeric";
            this.daysNumeric.Size = new System.Drawing.Size(106, 22);
            this.daysNumeric.TabIndex = 6;
            this.daysNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Experiment\'s number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Probability 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Probability 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Probability 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Probability 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Probability 5";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(39, 358);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(218, 59);
            this.buttonStart.TabIndex = 13;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.daysNumeric);
            this.Controls.Add(this.prob5);
            this.Controls.Add(this.prob4);
            this.Controls.Add(this.prob3);
            this.Controls.Add(this.prob2);
            this.Controls.Add(this.prob1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown prob1;
        private System.Windows.Forms.NumericUpDown prob2;
        private System.Windows.Forms.NumericUpDown prob3;
        private System.Windows.Forms.NumericUpDown prob4;
        private System.Windows.Forms.NumericUpDown prob5;
        private System.Windows.Forms.NumericUpDown daysNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonStart;
    }
}

