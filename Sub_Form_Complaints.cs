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
    public partial class Sub_Form_Complaints : Form
    {
        private Main_Program Program;

        public Sub_Form_Complaints(Main_Program program)
        {
            InitializeComponent();
            Main_Chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
            Program = program;
            Query();

        }
        
        //Button click events.
        private void Button_Return_Click(object sender, EventArgs e)
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
        public void Query()
        {
            DataTable table = new DataTable();

            SqlConnection Connection = new SqlConnection("Data Source=145.24.222.155,8080;Database=KickstartRotterdam;Persist Security Info=True;User ID=KickstartRotterdam;Password=Pr0ject3");
            Connection.Open();
            SqlCommand Command = new SqlCommand("select top 5 count(ComplaintID) as Amount, Cause from Complaints group by Cause order by cause desc", Connection);
            using (SqlDataAdapter Data = new SqlDataAdapter(Command)) { Data.Fill(table); }
            foreach (DataRow row in table.Rows)
            {
                Main_Chart.Series[0].Points.AddXY(row["Cause"], row["Amount"]);
            }
        }
    }
}
