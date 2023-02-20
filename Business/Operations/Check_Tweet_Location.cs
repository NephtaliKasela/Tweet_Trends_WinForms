using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Operations
{
    public class Check_Tweet_Location
    {
        public int count = 0;
        public void Check_Location(List<Tweet> tweets, List<State> states, ListBox box)
        {
            foreach(Tweet tweet in tweets)
            {
                IsInside(tweet, states, box);
            }
        }

        private void IsInside(Tweet tweet, List<State> states, ListBox box)
        {
            PointLatLng point = new PointLatLng(tweet.Coordinates.Latitude, tweet.Coordinates.Longitude);
            foreach (State state in states)
            {
                var polygon = Polygon(state);
                if(polygon.IsInside(point))
                {
                    tweet.Location = state.Name;

                    count += 1;
                    box.Items.Add(count.ToString());
                    Console.WriteLine(count.ToString());
                }
            }
        }

        private GMapPolygon Polygon(State state)
        {
            List<PointLatLng> points = new List<PointLatLng>();
            foreach (Geographic_Coordinates geoC in state.Coordinates)
            {
                PointLatLng point = new PointLatLng(geoC.Latitude,geoC.Longitude);
                points.Add(point);
            }

            var polygon = new GMapPolygon(points, "My area");
            return polygon;
        }
    }
}
