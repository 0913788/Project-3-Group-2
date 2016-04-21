using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;



namespace Kickstart_Rotterdam__Real_
{
    public partial class Sub_Form_Park_Ride : Form
    {
        GMapOverlay overlayOne;
        GMapMarker marker1;
        Main_Program Program;

        public Sub_Form_Park_Ride(Main_Program program)
        {
            InitializeComponent();
            Program = program;
            Show();
        }

        // Creates map with hardcoded markers.
        private void MapPR_Load(object sender, EventArgs e)
        {
            gMapControl1.SetPositionByKeywords("Rotterdam");
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 17;
            gMapControl1.Zoom = 11;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.Manager.Mode = AccessMode.ServerOnly;

            overlayOne = new GMapOverlay("Points");
            gMapControl1.Overlays.Add(overlayOne);
            overlayOne.Markers.Clear();
            overlayOne.Routes.Clear();

            marker1 = new GMarkerGoogle(new PointLatLng(51.95669663, 4.460062981), new Bitmap(Properties.Resources.Parking_marker));
            marker1.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker1.ToolTipText = "Meijersplein";
            overlayOne.Markers.Add(marker1);

            marker1 = new GMarkerGoogle(new PointLatLng(51.88711387, 4.491305351), new Bitmap(Properties.Resources.Parking_marker));
            marker1.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker1.ToolTipText = "Zuidplein";
            overlayOne.Markers.Add(marker1);

            marker1 = new GMarkerGoogle(new PointLatLng(51.92095267, 4.531731606), new Bitmap(Properties.Resources.Parking_marker));
            marker1.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker1.ToolTipText = "Kralingse Zoom";
            overlayOne.Markers.Add(marker1);

            marker1 = new GMarkerGoogle(new PointLatLng(51.9528749, 4.550077915), new Bitmap(Properties.Resources.Parking_marker));
            marker1.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker1.ToolTipText = "Alexander";
            overlayOne.Markers.Add(marker1);

            marker1 = new GMarkerGoogle(new PointLatLng(51.89486754, 4.534789324), new Bitmap(Properties.Resources.Parking_marker));
            marker1.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker1.ToolTipText = "Noorderhelling";
            overlayOne.Markers.Add(marker1);

            marker1 = new GMarkerGoogle(new PointLatLng(51.87298036, 4.47684288), new Bitmap(Properties.Resources.Parking_marker));
            marker1.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker1.ToolTipText = "Slinge";
            overlayOne.Markers.Add(marker1);

            marker1 = new GMarkerGoogle(new PointLatLng(51.879797, 4.532860), new Bitmap(Properties.Resources.Parking_marker));
            marker1.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker1.ToolTipText = "Lombardijen";
            overlayOne.Markers.Add(marker1);

            marker1 = new GMarkerGoogle(new PointLatLng(51.879797, 4.532860), new Bitmap(Properties.Resources.Parking_marker));
            marker1.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker1.ToolTipText = "Lombardijen";
            overlayOne.Markers.Add(marker1);

            marker1 = new GMarkerGoogle(new PointLatLng(51.960887, 4.463001), new Bitmap(Properties.Resources.Parking_marker));
            marker1.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker1.ToolTipText = "Wilgenplas";
            overlayOne.Markers.Add(marker1);

            marker1 = new GMarkerGoogle(new PointLatLng(51.932495, 4.563002), new Bitmap(Properties.Resources.Parking_marker));
            marker1.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker1.ToolTipText = "Schenkel";
            overlayOne.Markers.Add(marker1);

            marker1 = new GMarkerGoogle(new PointLatLng(51.980678, 4.582402), new Bitmap(Properties.Resources.Parking_marker));
            marker1.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker1.ToolTipText = "Nesselande";
            overlayOne.Markers.Add(marker1);

            marker1 = new GMarkerGoogle(new PointLatLng(51.881028, 4.381623), new Bitmap(Properties.Resources.Parking_marker));
            marker1.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker1.ToolTipText = "Pernis";
            overlayOne.Markers.Add(marker1);
            
            marker1 = new GMarkerGoogle(new PointLatLng(51.861445, 4.366621), new Bitmap(Properties.Resources.Parking_marker));
            marker1.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker1.ToolTipText = "Hoogvliet Centrum";
            overlayOne.Markers.Add(marker1);
            
            marker1 = new GMarkerGoogle(new PointLatLng(51.855243, 4.363318), new Bitmap(Properties.Resources.Parking_marker));
            marker1.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker1.ToolTipText = "Hoogvliet Zalmplaat";
            overlayOne.Markers.Add(marker1);

            marker1 = new GMarkerGoogle(new PointLatLng(51.863163, 4.376664), new Bitmap(Properties.Resources.Parking_marker));
            marker1.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker1.ToolTipText = "Hoogvliet Tussenwater";
            overlayOne.Markers.Add(marker1);


        }
    }
}
