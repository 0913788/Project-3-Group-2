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

//Sets the name of the program
namespace Kickstart_Rotterdam__Real_
{
    //Sets it as a form
    public partial class Sub_Form_PR : Form
    {
        private Main_Program Program;
        public Sub_Form_PR(Main_Program program)
        {
            InitializeComponent();
            Program = program;
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
            Main_Chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            Main_Chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            Query();
        }

        //If clicked, the map will come up
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var map = new Sub_Form_Park_Ride(Program);
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
        
        //Query for the current form.
        public void Query()
        {
            DataTable table = new DataTable();
            SqlConnection Connection = new SqlConnection("Data Source=145.24.222.155,8080;Database=KickstartRotterdam;Persist Security Info=True;User ID=KickstartRotterdam;Password=Pr0ject3");
            Connection.Open();

            SqlCommand Command = new SqlCommand("SELECT name, avg(TotalSpots-InUse) as Open_Spots,DATENAME(YY, Year) as Year FROM Parkinglot inner join Parking_Count on Parkinglot.ID = Parking_Count.Parking_ID WHERE Year = 2013 GROUP BY name, DATENAME(YY, Year) ORDER BY name, DATENAME(YY, Year)", Connection);
            using (SqlDataAdapter Data = new SqlDataAdapter(Command)) { Data.Fill(table); }
            foreach (DataRow row in table.Rows)
            {

                Main_Chart.Series[0].Points.AddXY(row["name"], row["Open_Spots"]);
            }
            Connection.Close();
        }
    }
}
