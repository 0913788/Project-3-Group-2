namespace Kickstart_Rotterdam__Real_
{
    partial class Sub_Form_Correlation
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Button_return = new System.Windows.Forms.PictureBox();
            this.Button_Exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Main_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Chart_Bicycle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Chart_Weather = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_Generate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Kickstart_Rotterdam__Real_.Properties.Resources.Main_logo;
            this.pictureBox2.Location = new System.Drawing.Point(97, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(431, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Button_return
            // 
            this.Button_return.BackColor = System.Drawing.Color.Transparent;
            this.Button_return.Image = global::Kickstart_Rotterdam__Real_.Properties.Resources.Button_return_arrow;
            this.Button_return.Location = new System.Drawing.Point(16, 15);
            this.Button_return.Margin = new System.Windows.Forms.Padding(4);
            this.Button_return.Name = "Button_return";
            this.Button_return.Size = new System.Drawing.Size(73, 68);
            this.Button_return.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Button_return.TabIndex = 6;
            this.Button_return.TabStop = false;
            this.Button_return.Click += new System.EventHandler(this.Button_return_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.Color.Transparent;
            this.Button_Exit.Image = global::Kickstart_Rotterdam__Real_.Properties.Resources.Button_exit_1;
            this.Button_Exit.Location = new System.Drawing.Point(536, 15);
            this.Button_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(73, 68);
            this.Button_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Button_Exit.TabIndex = 7;
            this.Button_Exit.TabStop = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Correlation; weather and bicycle thefts";
            // 
            // Main_Chart
            // 
            this.Main_Chart.BackColor = System.Drawing.Color.Transparent;
            this.Main_Chart.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.Main_Chart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.Main_Chart.Legends.Add(legend1);
            this.Main_Chart.Location = new System.Drawing.Point(-19, 194);
            this.Main_Chart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Main_Chart.Name = "Main_Chart";
            this.Main_Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.MarkerSize = 1;
            series1.Name = "Temperature in  °C";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.CustomProperties = "DrawSideBySide=True";
            series2.Legend = "Legend1";
            series2.MarkerSize = 1;
            series2.Name = "Amount of stolen bicycles";
            series2.YValuesPerPoint = 6;
            this.Main_Chart.Series.Add(series1);
            this.Main_Chart.Series.Add(series2);
            this.Main_Chart.Size = new System.Drawing.Size(643, 300);
            this.Main_Chart.TabIndex = 9;
            this.Main_Chart.Text = "chart1";
            // 
            // Chart_Bicycle
            // 
            this.Chart_Bicycle.FormattingEnabled = true;
            this.Chart_Bicycle.Items.AddRange(new object[] {
            "Column",
            "Line",
            "Spline"});
            this.Chart_Bicycle.Location = new System.Drawing.Point(271, 177);
            this.Chart_Bicycle.Name = "Chart_Bicycle";
            this.Chart_Bicycle.Size = new System.Drawing.Size(152, 24);
            this.Chart_Bicycle.TabIndex = 10;
            this.Chart_Bicycle.Text = "Choose chart type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(302, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bicycle thefts";
            // 
            // Chart_Weather
            // 
            this.Chart_Weather.FormattingEnabled = true;
            this.Chart_Weather.Items.AddRange(new object[] {
            "Column",
            "Line",
            "Spline"});
            this.Chart_Weather.Location = new System.Drawing.Point(87, 177);
            this.Chart_Weather.Name = "Chart_Weather";
            this.Chart_Weather.Size = new System.Drawing.Size(152, 24);
            this.Chart_Weather.TabIndex = 12;
            this.Chart_Weather.Text = "Choose chart type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(123, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Weather";
            // 
            // Button_Generate
            // 
            this.Button_Generate.Location = new System.Drawing.Point(455, 173);
            this.Button_Generate.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Generate.Name = "Button_Generate";
            this.Button_Generate.Size = new System.Drawing.Size(100, 28);
            this.Button_Generate.TabIndex = 14;
            this.Button_Generate.Text = "Generate chart";
            this.Button_Generate.UseVisualStyleBackColor = true;
            this.Button_Generate.Click += new System.EventHandler(this.Button_Generate_Click);
            // 
            // Sub_Form_Correlation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kickstart_Rotterdam__Real_.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(624, 519);
            this.Controls.Add(this.Button_Generate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Chart_Weather);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Chart_Bicycle);
            this.Controls.Add(this.Main_Chart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_return);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sub_Form_Correlation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sub_Correlation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Button_return;
        private System.Windows.Forms.PictureBox Button_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Main_Chart;
        private System.Windows.Forms.ComboBox Chart_Bicycle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Chart_Weather;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_Generate;
    }
}