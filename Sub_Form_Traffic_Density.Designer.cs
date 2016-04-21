namespace Kickstart_Rotterdam__Real_
{
    partial class Sub_Form_Traffic_Density
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Button_return = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Button_Exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Main_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DropDown_Hour = new System.Windows.Forms.ComboBox();
            this.DropDown_Day = new System.Windows.Forms.ComboBox();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Button_Generate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Button_return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_return
            // 
            this.Button_return.BackColor = System.Drawing.Color.Transparent;
            this.Button_return.Image = global::Kickstart_Rotterdam__Real_.Properties.Resources.Button_return_arrow;
            this.Button_return.Location = new System.Drawing.Point(12, 12);
            this.Button_return.Name = "Button_return";
            this.Button_return.Size = new System.Drawing.Size(55, 55);
            this.Button_return.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Button_return.TabIndex = 3;
            this.Button_return.TabStop = false;
            this.Button_return.Click += new System.EventHandler(this.Button_return_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Kickstart_Rotterdam__Real_.Properties.Resources.Main_logo;
            this.pictureBox2.Location = new System.Drawing.Point(73, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(323, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.Color.Transparent;
            this.Button_Exit.Image = global::Kickstart_Rotterdam__Real_.Properties.Resources.Button_exit_1;
            this.Button_Exit.Location = new System.Drawing.Point(402, 12);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(55, 55);
            this.Button_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Button_Exit.TabIndex = 5;
            this.Button_Exit.TabStop = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Traffic density on the Maasboulevard";
            // 
            // Main_Chart
            // 
            this.Main_Chart.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.Main_Chart.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Name = "Traffic_Density";
            this.Main_Chart.Legends.Add(legend4);
            this.Main_Chart.Location = new System.Drawing.Point(-20, 170);
            this.Main_Chart.Margin = new System.Windows.Forms.Padding(2);
            this.Main_Chart.Name = "Main_Chart";
            this.Main_Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Traffic_Density";
            series4.Name = "Amount of cars";
            this.Main_Chart.Series.Add(series4);
            this.Main_Chart.Size = new System.Drawing.Size(489, 242);
            this.Main_Chart.TabIndex = 7;
            this.Main_Chart.Text = "chart1";
            // 
            // DropDown_Hour
            // 
            this.DropDown_Hour.FormattingEnabled = true;
            this.DropDown_Hour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.DropDown_Hour.Location = new System.Drawing.Point(175, 157);
            this.DropDown_Hour.Name = "DropDown_Hour";
            this.DropDown_Hour.Size = new System.Drawing.Size(121, 21);
            this.DropDown_Hour.TabIndex = 10;
            this.DropDown_Hour.Text = "Choose an hour (opt)";
            // 
            // DropDown_Day
            // 
            this.DropDown_Day.FormattingEnabled = true;
            this.DropDown_Day.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.DropDown_Day.Location = new System.Drawing.Point(48, 157);
            this.DropDown_Day.Name = "DropDown_Day";
            this.DropDown_Day.Size = new System.Drawing.Size(121, 21);
            this.DropDown_Day.TabIndex = 10;
            this.DropDown_Day.Text = "Select a day (opt)";
            // 
            // kickstartRotterdamDataSet
            // 
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            // 
            // carsTableAdapter
            // 
            // 
            // Button_Generate
            // 
            this.Button_Generate.Location = new System.Drawing.Point(369, 157);
            this.Button_Generate.Name = "Button_Generate";
            this.Button_Generate.Size = new System.Drawing.Size(75, 23);
            this.Button_Generate.TabIndex = 11;
            this.Button_Generate.Text = "Generate chart";
            this.Button_Generate.UseVisualStyleBackColor = true;
            this.Button_Generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sub_Form_Traffic_Density
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kickstart_Rotterdam__Real_.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(468, 422);
            this.Controls.Add(this.Button_Generate);
            this.Controls.Add(this.DropDown_Day);
            this.Controls.Add(this.DropDown_Hour);
            this.Controls.Add(this.Main_Chart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Button_return);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Sub_Form_Traffic_Density";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.Button_return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Chart)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Button_return;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Button_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Main_Chart;
        private System.Windows.Forms.ComboBox DropDown_Hour;
        private System.Windows.Forms.ComboBox DropDown_Day;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private System.Windows.Forms.Button Button_Generate;
    }
}