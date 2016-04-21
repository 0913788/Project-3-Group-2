namespace Kickstart_Rotterdam__Real_
{
    partial class PDFChart
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
            this.Main_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Main_Chart.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.Main_Chart.Legends.Add(legend1);
            this.Main_Chart.Location = new System.Drawing.Point(-24, 2);
            this.Main_Chart.Name = "Main_Chart";
            series1.ChartArea = "ChartArea1";
            
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Main_Chart.Series.Add(series1);
            this.Main_Chart.Size = new System.Drawing.Size(486, 348);
            this.Main_Chart.TabIndex = 0;
            this.Main_Chart.Text = "chart1";
            // 
            // PDFChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 348);
            this.Controls.Add(this.Main_Chart);
            this.Name = "PDFChart";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Main_Chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Main_Chart;
    }
}