using GMap.NET.MapProviders;
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
    public class Print_Location_of_Tweet
    {
        public void Print_Location(List<Tweet> tweets, GMapControl gmcMap)
        {
            gmcMap.DragButton = MouseButtons.Left;
            gmcMap.MapProvider = GMapProviders.GoogleMap;

            foreach (Tweet t in tweets)
            {
                gmcMap.Position = new PointLatLng(t.Coordinates.Latitude, t.Coordinates.Longitude);
                gmcMap.MinZoom = 5;       // Minimum zoom level
                gmcMap.MaxZoom = 100;     // Maximum zoom level
                gmcMap.Zoom = 10;         // Current zoom level

                PointLatLng points = new PointLatLng(t.Coordinates.Latitude, t.Coordinates.Longitude);
                // Normal marker
                GMapMarker marker = new GMarkerGoogle(points, GMarkerGoogleType.red);

                // Create an Overlay
                GMapOverlay markers = new GMapOverlay("markers");

                // Add all available markers to that Overlay
                markers.Markers.Add(marker);

                // Cover map with Overlay
                gmcMap.Overlays.Add(markers);
            }
        }
    }
}
