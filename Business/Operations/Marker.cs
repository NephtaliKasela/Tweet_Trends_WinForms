using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Operations
{
    public class Marker
    {
        public void Print(double latitude, double longitude, GMapControl gmapC)
        {
            PointLatLng points = new PointLatLng(latitude, longitude);
            // Normal marker
            GMapMarker marker = new GMarkerGoogle(points, GMarkerGoogleType.lightblue_dot);

            // Create an Overlay
            GMapOverlay markers = new GMapOverlay("markers");

            // Add all available markers to that Overlay
            markers.Markers.Add(marker);

            // Cover map with Overlay
            gmapC.Overlays.Add(markers);
        }
    }
}
