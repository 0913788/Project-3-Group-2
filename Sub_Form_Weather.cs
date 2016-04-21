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

namespace Kickstart_Rotterdam__Real_
{
    public partial class Sub_Form_Weather : Form
    {
        private Main_Program Program;

        public Sub_Form_Weather(Main_Program program)
        {
            InitializeComponent();
            Program = program;
            Query("2015" , null);
            Main_Chart.ChartAreas[0].AxisX.Interval = 1;
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        // Button click events.
        private void Button_Return_Click(object sender, EventArgs e)
        {
            Program._State = 0;
            Dispose();
            Program._Busy = false;
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Program._State = 9;
            Dispose();
        }
        
        //Generates a chart which shows the data (between) given user input (ComboBox 1/2).
        private void button1_Click(object sender, EventArgs e)
        {
            {
                Main_Chart.Series[0].Points.Clear();
                var year = Convert.ToString(DropDown_Year.SelectedItem);
                var year1 = Convert.ToString(DropDown_Year1.SelectedItem);

                if (DropDown_Year.SelectedItem == null)
                {
                    if (DropDown_Year1.SelectedItem == null)
                    {
                        Query(null, null);
                    }
                    else
                    {
                        Query(null, year1);
                    }
                }
                else
                {
                    if (DropDown_Year1.SelectedItem == null)
                    {
                        Query(year, null);

                    }
                    else
                    {
                        Query(year, year1);

                    }

                }
                DropDown_Year1.SelectedItem = null;
                DropDown_Year.SelectedItem = null;

                DropDown_Year.Text = "Select a year (must).";
                DropDown_Year1.Text = "Select a year (opt).";
            }
        }

        //Query for the current form.
        public void Query(object year, object year1)
        {

            if (year != null)
            {
                Convert.ToString(year);
            }


            if (year1 != null)
            {
                Convert.ToString(year1);
            }


            string Year1;
            string Between;
            string And;



            if (year == null)
            {
                year = "is not null";
            }
            else            
            {
                if (year1 == null)
                {
                    year = "='" + year + "'";
                }
                else
                {
                    year = "'" + year + "'";
                }
            }


            if (year1 == null)
            {
                Year1 = "";
                Between = "";
                And = "";
            }
            else
            {
                Year1 = "'" + year1 + "'";
                Between = "Between";
                And = "And";
            }
            DataTable table = new DataTable();
            SqlConnection Connection = new SqlConnection("Data Source=145.24.222.155,8080;Database=KickstartRotterdam;Persist Security Info=True;User ID=KickstartRotterdam;Password=Pr0ject3");
            Connection.Open();

            SqlCommand Command = new SqlCommand(string.Format("select DATEPART(YY, MeasureDate) as Year, AVG(AverageTemperature / 10) as Amount, DATENAME(MM, MeasureDate) as Month, DATEPART(MM, MeasureDate) as MonthNumber from Weather where DATEPART(YY, MeasureDate){2} {0} {3} {1} group by DATEPART(YY, MeasureDate), DATENAME(MM, MeasureDate), DATEPART(MM, MeasureDate) order by DATEPART(YY, MeasureDate), DATEPART(MM, MeasureDate)",year,Year1,Between,And), Connection);
            using (SqlDataAdapter Data = new SqlDataAdapter(Command)) { Data.Fill(table); }
            foreach (DataRow row in table.Rows)
            {

                Main_Chart.Series[0].Points.AddXY(row["Month"], row["Amount"]);
            }
            Connection.Close();

        }
    }
}
