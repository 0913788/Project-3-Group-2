using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Kickstart_Rotterdam__Real_
{
    public partial class Splash_Screen : Form
    {
        private int ticks;

        public Splash_Screen()
        {
            InitializeComponent();
            ticks = 0;
            this.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(2);
            ticks++;
            if (ticks == 60)
            {
                timer1.Stop();
                Close();
                Dispose();
            }
        }
    }
}
