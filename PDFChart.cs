using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kickstart_Rotterdam__Real_
{
    // Form which is used by the PDFCreator class.
    public partial class PDFChart : Form
    {
        public Chart chart;
        public PDFChart()
        {
            InitializeComponent();
            Hide();
            chart = Main_Chart;
            Main_Chart.ChartAreas[0].AxisX.Interval = 1;
        }
    }
}
