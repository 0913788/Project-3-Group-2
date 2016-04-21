using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kickstart_Rotterdam__Real_
{
    public partial class Sub_Form_Traffic_Density : Form
    {
        private Main_Program Program;

        public Sub_Form_Traffic_Density(Main_Program program)
        
        {
            InitializeComponent();
            Program = program;
            Query(null,null);
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        //Button click events.
        private void Button_return_Click(object sender, EventArgs e)
        {
            Program._State = 0;
            Thread.Sleep(50);
            Dispose();
            Program._Busy = false;
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Program._State = 9;
            Dispose();
        }

        //Query for the current form.
        public void Query(object day, object hour)
        {
            Main_Chart.Series[0].Points.Clear();

            if (day != null)
            {
                Convert.ToString(day);
            }
           

            if (hour != null)
            {
                Convert.ToInt32(hour);
            }
           

            string Hour;
            string HourInput;
            string Comma;
            string And;

            

            if (day==null)
            {
                day = "is not null";
            }
            else
            {
                day = "='"+day+"'";
            }


            if (hour == null)
            {
                Hour = "";
                HourInput = "";
                Comma = "";
                And = "";
            }
            else
            {
                HourInput = "Datepart(hh,Dates)";
                Hour ="='"+hour+"'";
                Comma = ",";
                And = "And";
            }
            DataTable table = new DataTable();
            SqlConnection Connection = new SqlConnection("Data Source=145.24.222.155,8080;Database=KickstartRotterdam;Persist Security Info=True;User ID=KickstartRotterdam;Password=Pr0ject3");
            Connection.Open();

            SqlCommand Command = new SqlCommand(string.Format("select datepart(dd,Dates){3}{1}, count(Dates) as Cars, DATEname(dw,Dates) as Day from Cars where DATEname(dw,Dates){0} {4} {1}{2} group by DATEname(dw,Dates),Datepart(dd,Dates){3}{1} order by Datepart(dd,Dates){3}{1}", day,HourInput,Hour,Comma,And), Connection);
            using (SqlDataAdapter Data = new SqlDataAdapter(Command)) { Data.Fill(table); }
            foreach (DataRow row in table.Rows)
            {

                Main_Chart.Series[0].Points.AddXY(row["Day"], row["Cars"]);
            }
            Connection.Close();
        }

        //Generates chart customized by the user input (ComboBox 1/2).
        private void button1_Click(object sender, EventArgs e)
        {
            var day = Convert.ToString(DropDown_Day.SelectedItem);

            if (DropDown_Day.SelectedItem == null)
            {
                if (DropDown_Hour.SelectedItem == null)
                {
                    Query(null, null);
                }
                else
                {
                    Query(null, Convert.ToInt32(DropDown_Hour.SelectedItem));
                }
            }
            else
            {
                if (DropDown_Hour.SelectedItem == null) 
                {
                    Query(day, null);

                }
                else
                {
                    Query(day, Convert.ToInt32(DropDown_Hour.SelectedItem));

                }

            }
            DropDown_Hour.SelectedItem = null;
            DropDown_Day.SelectedItem = null;

            DropDown_Day.Text = "Select a day (opt).";
            DropDown_Hour.Text = "Select a hour (opt).";
        }
    }
}
