using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kickstart_Rotterdam__Real_
{
    public partial class Sub_Bicycle_Theft : Form
    {
        private Main_Program Program;

        public Sub_Bicycle_Theft(Main_Program program)
        {
            InitializeComponent();
            Program = program;
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
            Query();
        }

        //Button click events.
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Program._State = 9;
            Dispose();
        }

        private void Button_return_Click(object sender, EventArgs e)
        {
            Program._State = 0;
            Thread.Sleep(50);
            Dispose();
            Program._Busy = false;
        }

        //Query for the current form.
        public void Query()
        {
            DataTable table = new DataTable();
            SqlConnection Connection = new SqlConnection("Data Source=145.24.222.155,8080;Database=KickstartRotterdam;Persist Security Info=True;User ID=KickstartRotterdam;Password=Pr0ject3");
            Connection.Open();

            SqlCommand Command = new SqlCommand("SELECT month(cast(TheftDate as DATE)), convert(char(3), TheftDate, 0) as Months, count(TheftID) as total from BicycleTheft group by month(cast(TheftDate as DATE)),convert(char(3), TheftDate, 0)order by month(cast(TheftDate as DATE))", Connection);
            using (SqlDataAdapter Data = new SqlDataAdapter(Command)) { Data.Fill(table); }
            foreach (DataRow row in table.Rows)
            {

               Main_Chart.Series["Bicycle thefts"].Points.AddXY(row["Months"], row["total"]);
            }
            Connection.Close();
        }
    }
}
