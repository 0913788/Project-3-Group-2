namespace Kickstart_Rotterdam__Real_
{
    partial class Sub_Form_Weather
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_Return = new System.Windows.Forms.PictureBox();
            this.Button_Exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Main_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DropDown_Year = new System.Windows.Forms.ComboBox();
            this.DropDown_Year1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Kickstart_Rotterdam__Real_.Properties.Resources.Main_logo;
            this.pictureBox1.Location = new System.Drawing.Point(72, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Button_Return
            // 
            this.Button_Return.BackColor = System.Drawing.Color.Transparent;
            this.Button_Return.Image = global::Kickstart_Rotterdam__Real_.Properties.Resources.Button_return_arrow;
            this.Button_Return.Location = new System.Drawing.Point(10, 12);
            this.Button_Return.Name = "Button_Return";
            this.Button_Return.Size = new System.Drawing.Size(56, 55);
            this.Button_Return.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Button_Return.TabIndex = 3;
            this.Button_Return.TabStop = false;
            this.Button_Return.Click += new System.EventHandler(this.Button_Return_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.Color.Transparent;
            this.Button_Exit.Image = global::Kickstart_Rotterdam__Real_.Properties.Resources.Button_exit_1;
            this.Button_Exit.Location = new System.Drawing.Point(401, 12);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(55, 55);
            this.Button_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Button_Exit.TabIndex = 4;
            this.Button_Exit.TabStop = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Average temperature per day";
            // 
            // Main_Chart
            // 
            this.Main_Chart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.Main_Chart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.ItemColumnSpacing = 25;
            legend1.Name = "Legend1";
            this.Main_Chart.Legends.Add(legend1);
            this.Main_Chart.Location = new System.Drawing.Point(-17, 157);
            this.Main_Chart.Margin = new System.Windows.Forms.Padding(2);
            this.Main_Chart.Name = "Main_Chart";
            this.Main_Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series1.Legend = "Legend1";
            series1.Name = "Average temperature (°C)";
            this.Main_Chart.Series.Add(series1);
            this.Main_Chart.Size = new System.Drawing.Size(490, 266);
            this.Main_Chart.TabIndex = 6;
            this.Main_Chart.Text = "chart1";
            // 
            // DropDown_Year
            // 
            this.DropDown_Year.FormattingEnabled = true;
            this.DropDown_Year.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015"});
            this.DropDown_Year.Location = new System.Drawing.Point(44, 140);
            this.DropDown_Year.Name = "DropDown_Year";
            this.DropDown_Year.Size = new System.Drawing.Size(121, 21);
            this.DropDown_Year.TabIndex = 7;
            this.DropDown_Year.Text = "Select a year (must)";
            // 
            // DropDown_Year1
            // 
            this.DropDown_Year1.FormattingEnabled = true;
            this.DropDown_Year1.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015"});
            this.DropDown_Year1.Location = new System.Drawing.Point(171, 140);
            this.DropDown_Year1.Name = "DropDown_Year1";
            this.DropDown_Year1.Size = new System.Drawing.Size(121, 21);
            this.DropDown_Year1.TabIndex = 8;
            this.DropDown_Year1.Text = "Select a year (opt)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sub_Form_Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kickstart_Rotterdam__Real_.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(468, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DropDown_Year1);
            this.Controls.Add(this.DropDown_Year);
            this.Controls.Add(this.Main_Chart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Return);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Sub_Form_Weather";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Button_Return;
        private System.Windows.Forms.PictureBox Button_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Main_Chart;
        private System.Windows.Forms.ComboBox DropDown_Year;
        private System.Windows.Forms.ComboBox DropDown_Year1;
        private System.Windows.Forms.Button button1;
    }
}