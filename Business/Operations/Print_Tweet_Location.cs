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
    public class Print_Tweet_Location
    {
        public void Print_Location(List<Tweet> tweets, GMapControl gmapC)
        {
            gmapC.DragButton = MouseButtons.Left;
            gmapC.MapProvider = GMapProviders.GoogleMap;

            foreach (Tweet t in tweets)
            {
                gmapC.Position = new PointLatLng(t.Coordinates.Latitude, t.Coordinates.Longitude);
                gmapC.MinZoom = 5;       // Minimum zoom level
                gmapC.MaxZoom = 100;     // Maximum zoom level
                gmapC.Zoom = 10;         // Current zoom level

                // Print the location of the tweet
                Marker marker = new Marker();
                marker.Print(t.Coordinates.Latitude, t.Coordinates.Longitude, gmapC);
            }
        }
    }
}
