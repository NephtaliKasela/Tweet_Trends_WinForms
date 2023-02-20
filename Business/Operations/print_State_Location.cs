using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Operations
{
    public class print_State_Location
    {
        public void Print_Location(List<State> states, GMapControl gmapC)
        {
            gmapC.DragButton = MouseButtons.Left;
            gmapC.MapProvider = GMapProviders.GoogleMap;

            foreach (State state in states)
            {
                List<PointLatLng> points= new List<PointLatLng>();
                foreach (Geographic_Coordinates geoc in state.Coordinates)
                {
                    double lat = geoc.Latitude;
                    double longt = geoc.Longitude;

                    gmapC.Position = new PointLatLng(lat, longt);
                    gmapC.MinZoom = 5;       // Minimum zoom level
                    gmapC.MaxZoom = 100;     // Maximum zoom level
                    gmapC.Zoom = 10;         // Current zoom level

                    PointLatLng point = new PointLatLng(lat, longt);    
                    points.Add(point);
                }
                // Print the location of the state
                Polygon polygon= new Polygon();
                polygon.Print(points, gmapC);
            }
        }
    }
}
