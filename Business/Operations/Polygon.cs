using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Operations
{
    public class Polygon
    {
        public void Print(List<PointLatLng> points, GMapControl gmapC)
        {
            var polygon = new GMapPolygon(points, "My area")
            {
                Stroke = new Pen(Color.CornflowerBlue, 2),
                Fill = new SolidBrush(Color.Firebrick),
            };
            var polygons = new GMapOverlay("polygons");
            polygons.Polygons.Add(polygon);
            gmapC.Overlays.Add(polygons);
        }
    }
}
