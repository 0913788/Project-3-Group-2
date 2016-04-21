using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kickstart_Rotterdam__Real_
{
    class PDFCreator
    {
        private Chart chart;
        private PDFChart form;

        public PDFCreator()
        {
            form = new PDFChart();
        }

        public void overview() 
            {

            // Document creator with page sizes
            Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 30);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("Overview.pdf", FileMode.Create));
            doc.Open();
            //Text and font variables
            var titleFont = FontFactory.GetFont("Courier", 24, BaseColor.BLACK);
            var textFont = FontFactory.GetFont("Courier", 18, BaseColor.BLACK);
            var docTitle = new Paragraph("Project KickStart Rotterdam report\n\n", titleFont);
            var timeText = new Paragraph("Created on: " + DateTime.Now.ToString() + "\n\n", textFont);
            var authors = new Paragraph("Presented to you by: Ricardo Stam, Whitney Cheung, Marinda Kooiman and Mark Slingerland.\n\n", textFont);
            var Diagram1 = new Paragraph("Average amount of bicycle thefts each month\n", textFont);
            var Diagram2 = new Paragraph("Average temperature per day\n", textFont);
            var Diagram3 = new Paragraph("Correlation; weather and bicycle thefts\n", textFont);
            var Diagram4 = new Paragraph("Type and amount of complaints\n", textFont);
            var Diagram5 = new Paragraph("Traffic density on the Maasboulevard\n", textFont);
            var Diagram6 = new Paragraph("Average amount of open parking spots\n", textFont);
            //Text allignments so it will be centered
            timeText.Alignment = Element.ALIGN_CENTER;
            docTitle.Alignment = Element.ALIGN_CENTER;
            authors.Alignment = Element.ALIGN_CENTER;
            Diagram1.Alignment = Element.ALIGN_CENTER;
            Diagram2.Alignment = Element.ALIGN_CENTER;
            Diagram3.Alignment = Element.ALIGN_CENTER;
            Diagram4.Alignment = Element.ALIGN_CENTER;
            Diagram5.Alignment = Element.ALIGN_CENTER;
            Diagram6.Alignment = Element.ALIGN_CENTER;

            //Text adding
            doc.Add(docTitle);
            doc.Add(authors);
            doc.Add(timeText);
            doc.NewPage();
            doc.Add(Diagram1);
                
            
            // Chart Queries and adding as picture + Title Text           
            Query(1);
            using (var chartimage = new MemoryStream())
            {
                chart.SaveImage(chartimage, ChartImageFormat.Png);
                iTextSharp.text.Image Chart_Image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer());
                Chart_Image.Alignment = Element.ALIGN_CENTER;
                doc.Add(Chart_Image);


            }
            doc.Add(Diagram2);
            Query(2);
            form.chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            using (var chartimage = new MemoryStream())
            {
                chart.SaveImage(chartimage, ChartImageFormat.Png);
                iTextSharp.text.Image Chart_Image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer());
                Chart_Image.Alignment = Element.ALIGN_CENTER;
                doc.Add(Chart_Image);
                
            }
            doc.Add(Diagram3);
            Query(3);
            form.chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            using (var chartimage = new MemoryStream())
            {
                chart.SaveImage(chartimage, ChartImageFormat.Png);
                iTextSharp.text.Image Chart_Image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer());
                Chart_Image.Alignment = Element.ALIGN_CENTER;
                doc.Add(Chart_Image);

            }
            doc.Add(Diagram4);
            Query(4);
            using (var chartimage = new MemoryStream())
            {
                chart.SaveImage(chartimage, ChartImageFormat.Png);
                iTextSharp.text.Image Chart_Image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer());
                Chart_Image.Alignment = Element.ALIGN_CENTER;
                doc.Add(Chart_Image);

            }
            doc.Add(Diagram5);
            Query(5);
            using (var chartimage = new MemoryStream())
            {
                chart.SaveImage(chartimage, ChartImageFormat.Png);
                iTextSharp.text.Image Chart_Image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer());
                Chart_Image.Alignment = Element.ALIGN_CENTER;
                doc.Add(Chart_Image);
            }
            doc.Add(Diagram6);
            Query(6);
            using (var chartimage = new MemoryStream())
            {
                chart.SaveImage(chartimage, ChartImageFormat.Png);
                iTextSharp.text.Image Chart_Image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer());
                Chart_Image.Alignment = Element.ALIGN_CENTER;
                doc.Add(Chart_Image);
            }
            doc.Close();

        }

        private void Query(int type)
        {
            form.chart.Series[0].Points.Clear();
            DataTable table = new DataTable();
            SqlConnection Connection = new SqlConnection("Data Source=145.24.222.155,8080;Database=KickstartRotterdam;Persist Security Info=True;User ID=KickstartRotterdam;Password=Pr0ject3");
            Connection.Open();
            //Select a query by type and returns the information for the charts.
            switch (type)
            {
                case 1:
                    form.chart.Series[0].IsValueShownAsLabel = true;
                    SqlCommand Command = new SqlCommand("SELECT month(cast(TheftDate as DATE)), convert(char(3), TheftDate, 0) as Months, count(TheftID) as total from BicycleTheft group by month(cast(TheftDate as DATE)),convert(char(3), TheftDate, 0)order by month(cast(TheftDate as DATE))", Connection);
                    using (SqlDataAdapter Data = new SqlDataAdapter(Command)) { Data.Fill(table); }
                    foreach (DataRow row in table.Rows)
                    {
                        
                        form.chart.Series[0].Points.AddXY(row["Months"], row["total"]);
                        form.chart.Series[0].LegendText = "Bicycle thefts";
                    }
                    chart = form.chart;
                    Connection.Close();
                    break;
                case 2:
                    form.chart.Series[0].IsValueShownAsLabel = false;
                    Command = new SqlCommand("select DATEPART(YY, MeasureDate) as Year, AVG(AverageTemperature / 10) as Amount, DATENAME(MM, MeasureDate) as Month, DATEPART(MM, MeasureDate) as MonthNumber from Weather where DATEPART(YY, MeasureDate)=2015 group by DATEPART(YY, MeasureDate), DATENAME(MM, MeasureDate), DATEPART(MM, MeasureDate) order by DATEPART(YY, MeasureDate), DATEPART(MM, MeasureDate)", Connection);
                    using (SqlDataAdapter Data = new SqlDataAdapter(Command)) { Data.Fill(table); }
                    foreach (DataRow row in table.Rows)
                    {

                        form.chart.Series[0].Points.AddXY(row["Month"], row["Amount"]);
                        form.chart.Series[0].LegendText = "Average temperature";
                    }
                    chart = form.chart;
                    Connection.Close();
                    break;
                case 3:
                    form.chart.Series.Clear();
                    form.chart.Series.Add("Average temperature");
                    form.chart.Series.Add("Stolen bicycles");
                    form.chart.Series[0].YAxisType = AxisType.Primary;
                    form.chart.Series[1].YAxisType = AxisType.Secondary;
                    form.chart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    form.chart.ChartAreas[0].AxisY2.LineColor = Color.Transparent;
                    form.chart.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;
                    form.chart.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;
                    form.chart.ChartAreas[0].AxisY2.IsStartedFromZero = form.chart.ChartAreas[0].AxisY.IsStartedFromZero;
                    form.chart.Series[1].BorderWidth = 3;
                    form.chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    form.chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

                    Command = new SqlCommand("SELECT Datename(MM,MeasureDate)as months, avg(AverageTemperature)/10 as temperature ,count(TheftID) as stolen_bicycles, DATEPART(yy, MeasureDate),Datepart(MM,MeasureDate) from Weather inner join BicycleTheft on BicycleTheft.TheftDate = Weather.MeasureDate where DATEPART(yy, MeasureDate) = 2011 group by Datename(MM,MeasureDate),DATEPART(yy, MeasureDate),Datepart(MM,MeasureDate) order by Datepart(MM,MeasureDate) asc", Connection);
                    using (SqlDataAdapter Data = new SqlDataAdapter(Command)) { Data.Fill(table); }
                    foreach (DataRow row in table.Rows)
                    {
                        form.chart.Series[0].Points.AddXY(row["months"], row["temperature"]);
                        form.chart.Series[1].Points.AddXY(row["months"], row["stolen_Bicycles"]);
                        form.chart.Series[0].LegendText = "Average temperature";

                    }
                    chart = form.chart;
                    Connection.Close();
                    break;
                case 4:
                    form.chart.Series.Clear();
                    form.chart.Series.Add("Series1");
                    form.chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    Command = new SqlCommand("select top 5 count(ComplaintID) as Amount, Cause from Complaints group by Cause order by cause desc", Connection);
                    using (SqlDataAdapter Data = new SqlDataAdapter(Command)) { Data.Fill(table); }
                    foreach (DataRow row in table.Rows)
                    {
                        form.chart.Series[0].Points.AddXY(row["Cause"], row["Amount"]);
                    }
                    form.chart.Series[0].IsValueShownAsLabel = true;
                    chart = form.chart;
                    Connection.Close();
                    break;
                case 5:
                    form.chart.ChartAreas[0].AxisY2.Enabled = AxisEnabled.False;
                    form.chart.Series.Clear();
                    form.chart.Series.Add("Total Amount of cars");
                    form.chart.Series[0].IsValueShownAsLabel = true;
                    form.chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    Command = new SqlCommand("select datepart(dd,Dates), count(Dates) as Cars, DATEname(dw,Dates) as Day from Cars where DATEname(dw,Dates) is not null group by DATEname(dw,Dates),Datepart(dd,Dates) order by Datepart(dd,Dates)", Connection);
                    using (SqlDataAdapter Data = new SqlDataAdapter(Command)) { Data.Fill(table); }
                    foreach (DataRow row in table.Rows)
                    {

                        form.chart.Series[0].Points.AddXY(row["Day"], row["Cars"]);
                    }
                    chart = form.chart;
                    Connection.Close();
                    break;
                case 6:
                    form.chart.Series.Clear();
                    form.chart.Series.Add("average open spots");
                    form.chart.Series[0].IsValueShownAsLabel = true;
                    form.chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    Command = new SqlCommand("SELECT name, avg(TotalSpots - InUse) as Open_Spots, DATENAME(YY, Year) as Year FROM Parkinglot inner join Parking_Count on Parkinglot.ID = Parking_Count.Parking_ID WHERE Year = 2013 GROUP BY name, DATENAME(YY, Year) ORDER BY name, DATENAME(YY, Year)", Connection);
                    using (SqlDataAdapter Data = new SqlDataAdapter(Command)) { Data.Fill(table); }
                    foreach (DataRow row in table.Rows)
                    {

                        form.chart.Series[0].Points.AddXY(row["name"], row["Open_Spots"]);
                    }
                    chart = form.chart;
                    Connection.Close();
                    break;

            }
        }
    }
}
