using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;
using System.Data.SqlClient;

namespace Kickstart_Rotterdam__Real_
{
    public partial class Main_Menu : Form
    {
        Main_Program Program;
        bool mouseover;

        public Main_Menu(Main_Program program)
        {
            Program = program;
            mouseover = false;
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        // Mouse over & leave events.
        private void Button_Bicycle_Theft_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseover == false)
            {
                Button_Bicycle_Theft.Image = (Properties.Resources.Button_bicycle_theft_2);
                mouseover = true;
            }
        }

        private void Button_Bicycle_Theft_MouseLeave(object sender, EventArgs e)
        {
            Button_Bicycle_Theft.Image = (Properties.Resources.Button_bicycle_theft_1);
            mouseover = false;
        }

        private void Button_Weather_MouseLeave(object sender, EventArgs e)
        {
            Button_Weather.Image = (Properties.Resources.Button_weather_1);
            mouseover = false;
        }

        private void Button_Weather_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseover == false)
            {
                Button_Weather.Image = (Properties.Resources.Button_weather_2);
                mouseover = true;
            }
        }

        private void Button_Weather_Bicycle_MouseLeave(object sender, EventArgs e)
        {
            Button_Weather_Bicycle.Image = (Properties.Resources.Button_weather_bicycle_1);
            mouseover = false;
        }

        private void Button_Weather_Bicycle_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseover == false)
            {
                Button_Weather_Bicycle.Image = (Properties.Resources.Button_weather_bicycle_2);
                mouseover = true;
            }
        }

        private void Button_Complaints_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseover == false)
            {
                Button_Complaints.Image = (Properties.Resources.Button_complaints_2);
                mouseover = true;
            }
        }

        private void Button_Complaints_MouseLeave(object sender, EventArgs e)
        {
            Button_Complaints.Image = (Properties.Resources.Button_complaints_1);
            mouseover = false;
        }

        private void Button_Traffic_Density_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseover == false)
            {
                Button_Traffic_Density.Image = (Properties.Resources.Button_traffic__density_2);
                mouseover = true;
            }
        }

        private void Button_Traffic_Density_MouseLeave(object sender, EventArgs e)
        {
            Button_Traffic_Density.Image = (Properties.Resources.Button_traffic__density_1);
            mouseover = false;
        }

        private void Button_Park_Ride_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseover == false)
            {
                Button_Park_Ride.Image = (Properties.Resources.Button_PR_2);
                mouseover = true;
            }
        }

        private void Button_Park_Ride_MouseLeave(object sender, EventArgs e)
        {
            Button_Park_Ride.Image = (Properties.Resources.Button_PR_1);
            mouseover = false;
        }


        //Click events for button clicks.
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Program._State = 9;
            Application.ExitThread();
        }

        private void Button_Bicycle_Theft_Click(object sender, EventArgs e)
        {
            Program._State = 1;
            Dispose();
            Program._Busy = false;
        }

        private void Button_Weather_Click(object sender, EventArgs e)
        {
            Program._State = 2;
            Dispose();
            Program._Busy = false;
        }

        private void Button_Weather_Bicycle_Click(object sender, EventArgs e)
        {
            Program._State = 3;
            Dispose();
            Program._Busy = false;
        }

        private void Button_Complaints_Click(object sender, EventArgs e)
        {
            Program._State = 4;
            Dispose();
            Program._Busy = false;
        }

        private void Button_Traffic_Density_Click(object sender, EventArgs e)
        {
            Program._State = 5;
            Dispose();
            Program._Busy = false;
        }

        private void Button_Park_Ride_Click(object sender, EventArgs e)
        {
            Program._State = 6;
            Dispose();
            Program._Busy = false;
        }


        /// PDF overview button.
        private void button1_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(()=>new PDFCreator().overview());
        }
    }
}
