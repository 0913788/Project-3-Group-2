using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

//Sets the name of the program
namespace Kickstart_Rotterdam__Real_
{
    public partial class Sub_Form_Correlation : Form
    {
        private Main_Program Program;
        public Sub_Form_Correlation(Main_Program program)
        {
            InitializeComponent();
            Program = program;
            Query();
            Main_Chart.Series[0].YAxisType = AxisType.Primary;
            Main_Chart.Series[1].YAxisType = AxisType.Secondary;

            Main_Chart.ChartAreas[0].AxisY2.LineColor = Color.Transparent;
            Main_Chart.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;
            Main_Chart.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;
            Main_Chart.ChartAreas[0].AxisY2.IsStartedFromZero = Main_Chart.ChartAreas[0].AxisY.IsStartedFromZero;

            Main_Chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            Main_Chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        //If clicked, you will return to the main menu
        private void Button_return_Click(object sender, EventArgs e)
        {
            Program._State = 0;
            Dispose();
            Program._Busy = false;
        }

        //If clicked, you will leave the program
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Program._State = 9;
            Dispose();
        }

        //Imports the sql queries in a table and creates the X and Y values as selected.
        public void Query()
        {
            DataTable table = new DataTable();
            SqlConnection Connection = new SqlConnection("Data Source=145.24.222.155,8080;Database=KickstartRotterdam;Persist Security Info=True;User ID=KickstartRotterdam;Password=Pr0ject3");
            Connection.Open();

            SqlCommand Command = new SqlCommand("SELECT Datename(MM,MeasureDate)as months, avg(AverageTemperature)/10 as temperature ,count(TheftID) as stolen_bicycles, DATEPART(yy, MeasureDate),Datepart(MM,MeasureDate) from Weather inner join BicycleTheft on BicycleTheft.TheftDate = Weather.MeasureDate where DATEPART(yy, MeasureDate) = 2011 group by Datename(MM,MeasureDate),DATEPART(yy, MeasureDate),Datepart(MM,MeasureDate) order by Datepart(MM,MeasureDate) asc", Connection);
            using (SqlDataAdapter Data = new SqlDataAdapter(Command)) { Data.Fill(table); }
            foreach (DataRow row in table.Rows)
            {

                Main_Chart.Series[0].Points.AddXY(row["months"], row["temperature"]);
                Main_Chart.Series[1].Points.AddXY(row["months"], row["stolen_bicycles"]);
            }
            Connection.Close();
        }

        //If clicked the chosen chart types (ComboBox 1/2) will be shown.
        private void Button_Generate_Click(object sender, EventArgs e)
        {
            string weather;
            string bicycle;

            if (Chart_Weather.SelectedItem != null)
            {
                weather = Convert.ToString(Chart_Weather.SelectedItem);
            }
            else
            {
                weather = null;
            }

            if (Chart_Bicycle.SelectedItem != null)
            {
                bicycle = Convert.ToString(Chart_Bicycle.SelectedItem);
            }
            else
            {
                bicycle = null;
            }

            Main_Chart.Series[0].Points.Clear();
            Main_Chart.Series[1].Points.Clear();
            if (weather == null)
            {
                Main_Chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }
            else
            {
                if (weather == "Column")
                {
                    Main_Chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                }
                else
                {
                    if (weather == "Line")
                    {
                        Main_Chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        Main_Chart.Series[0].BorderWidth = 3;
                    }
                    else
                    {
                        if (weather == "Spline")
                        {
                            Main_Chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                            Main_Chart.Series[0].BorderWidth = 3;
                        }
                    }
                }
            }

            if (bicycle == null)
            {
                Main_Chart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            }
            else
            {
                if (bicycle == "Column")
                {
                    Main_Chart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                }
                else
                {
                    if (bicycle == "Line")
                    {
                        Main_Chart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        Main_Chart.Series[1].BorderWidth = 3;
                    }
                    else
                    {
                        if (bicycle == "Spline")
                        {
                            Main_Chart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                            Main_Chart.Series[1].BorderWidth = 3;
                        }
                    }
                }
            }

            Query();
        }
    }
}
