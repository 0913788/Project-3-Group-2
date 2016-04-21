namespace Kickstart_Rotterdam__Real_
{
    partial class Sub_Bicycle_Theft
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
            this.Button_return = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Button_Exit = new System.Windows.Forms.PictureBox();
            this.Main_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Button_return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_return
            // 
            this.Button_return.BackColor = System.Drawing.Color.Transparent;
            this.Button_return.Image = global::Kickstart_Rotterdam__Real_.Properties.Resources.Button_return_arrow;
            this.Button_return.Location = new System.Drawing.Point(16, 15);
            this.Button_return.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_return.Name = "Button_return";
            this.Button_return.Size = new System.Drawing.Size(73, 68);
            this.Button_return.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Button_return.TabIndex = 2;
            this.Button_return.TabStop = false;
            this.Button_return.Click += new System.EventHandler(this.Button_return_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Kickstart_Rotterdam__Real_.Properties.Resources.Main_logo;
            this.pictureBox2.Location = new System.Drawing.Point(97, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(431, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.Color.Transparent;
            this.Button_Exit.Image = global::Kickstart_Rotterdam__Real_.Properties.Resources.Button_exit_1;
            this.Button_Exit.Location = new System.Drawing.Point(536, 15);
            this.Button_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(73, 68);
            this.Button_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Button_Exit.TabIndex = 2;
            this.Button_Exit.TabStop = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Main_Chart
            // 
            this.Main_Chart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.Main_Chart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.IsDockedInsideChartArea = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.Transparent;
            this.Main_Chart.Legends.Add(legend1);
            this.Main_Chart.Location = new System.Drawing.Point(-1, 154);
            this.Main_Chart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Main_Chart.Name = "Main_Chart";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series1.Legend = "Legend1";
            series1.Name = "Bicycle thefts";
            series1.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series1.SmartLabelStyle.IsOverlappedHidden = false;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.Main_Chart.Series.Add(series1);
            this.Main_Chart.Size = new System.Drawing.Size(628, 366);
            this.Main_Chart.TabIndex = 1;
            this.Main_Chart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Average amount of bicycle thefts each month";
            // 
            // Sub_Bicycle_Theft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kickstart_Rotterdam__Real_.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(624, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Main_Chart);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_return);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Sub_Bicycle_Theft";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sub_Bicycle_Theft";
            ((System.ComponentModel.ISupportInitialize)(this.Button_return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Button_return;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Button_Exit;
        private System.Windows.Forms.DataVisualization.Charting.Chart Main_Chart;
        private System.Windows.Forms.Label label1;
    }
}