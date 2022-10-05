namespace FlowModel.Forms
{
    partial class OutputGraf
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutputGraf));
            this.GTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GViscosity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Back = new System.Windows.Forms.Button();
            this.Tabl = new System.Windows.Forms.Button();
            this.ViscosityLabel = new System.Windows.Forms.Label();
            this.TempLabel = new System.Windows.Forms.Label();
            this.PerformanceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViscosity)).BeginInit();
            this.SuspendLayout();
            // 
            // GTemp
            // 
            chartArea1.Name = "ChartArea1";
            this.GTemp.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.GTemp.Legends.Add(legend1);
            this.GTemp.Location = new System.Drawing.Point(8, 37);
            this.GTemp.Name = "GTemp";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "Temp";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.GTemp.Series.Add(series1);
            this.GTemp.Size = new System.Drawing.Size(470, 355);
            this.GTemp.TabIndex = 0;
            this.GTemp.Text = "chart1";
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            title1.Name = "Title1";
            title1.Text = "Температура, С";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title2.Name = "Title2";
            title2.Text = "Координаты по длине канала, м";
            this.GTemp.Titles.Add(title1);
            this.GTemp.Titles.Add(title2);
            // 
            // GViscosity
            // 
            chartArea2.Name = "ChartArea1";
            this.GViscosity.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.GViscosity.Legends.Add(legend2);
            this.GViscosity.Location = new System.Drawing.Point(484, 37);
            this.GViscosity.Name = "GViscosity";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "Viscosity";
            this.GViscosity.Series.Add(series2);
            this.GViscosity.Size = new System.Drawing.Size(470, 355);
            this.GViscosity.TabIndex = 1;
            title3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            title3.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            title3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopRight;
            title3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            title3.BorderWidth = 0;
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title3.Name = "V";
            title3.Text = "Вязкость, Па*с";
            title3.ToolTip = "ыва";
            title4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title4.Name = "k";
            title4.Text = "Координаты по длине канала, м";
            this.GViscosity.Titles.Add(title3);
            this.GViscosity.Titles.Add(title4);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(12, 429);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(175, 44);
            this.Back.TabIndex = 12;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Tabl
            // 
            this.Tabl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tabl.Location = new System.Drawing.Point(775, 418);
            this.Tabl.Name = "Tabl";
            this.Tabl.Size = new System.Drawing.Size(175, 55);
            this.Tabl.TabIndex = 13;
            this.Tabl.Text = "Показать таблицу";
            this.Tabl.UseVisualStyleBackColor = true;
            this.Tabl.Click += new System.EventHandler(this.Tabl_Click);
            // 
            // ViscosityLabel
            // 
            this.ViscosityLabel.AutoSize = true;
            this.ViscosityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViscosityLabel.Location = new System.Drawing.Point(479, 439);
            this.ViscosityLabel.Name = "ViscosityLabel";
            this.ViscosityLabel.Size = new System.Drawing.Size(17, 18);
            this.ViscosityLabel.TabIndex = 24;
            this.ViscosityLabel.Text = "0";
            // 
            // TempLabel
            // 
            this.TempLabel.AutoSize = true;
            this.TempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TempLabel.Location = new System.Drawing.Point(505, 418);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(17, 18);
            this.TempLabel.TabIndex = 23;
            this.TempLabel.Text = "0";
            // 
            // PerformanceLabel
            // 
            this.PerformanceLabel.AutoSize = true;
            this.PerformanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PerformanceLabel.Location = new System.Drawing.Point(572, 397);
            this.PerformanceLabel.Name = "PerformanceLabel";
            this.PerformanceLabel.Size = new System.Drawing.Size(17, 18);
            this.PerformanceLabel.TabIndex = 22;
            this.PerformanceLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(386, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Вязкость:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(385, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Температура:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(385, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Производительность:";
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerLabel.Location = new System.Drawing.Point(555, 457);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(17, 18);
            this.TimerLabel.TabIndex = 26;
            this.TimerLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(386, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Время выполнения:";
            // 
            // OutputGraf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 485);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ViscosityLabel);
            this.Controls.Add(this.TempLabel);
            this.Controls.Add(this.PerformanceLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tabl);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.GViscosity);
            this.Controls.Add(this.GTemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OutputGraf";
            this.Text = "Графики температуры и вязкости";
            ((System.ComponentModel.ISupportInitialize)(this.GTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViscosity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GTemp;
        private System.Windows.Forms.DataVisualization.Charting.Chart GViscosity;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Tabl;
        private System.Windows.Forms.Label ViscosityLabel;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.Label PerformanceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label label5;
    }
}