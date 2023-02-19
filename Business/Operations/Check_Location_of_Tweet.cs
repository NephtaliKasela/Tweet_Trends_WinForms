using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Operations
{
    internal class Check_Location_of_Tweet
    {
        public void Check_Location(List<Tweet> tweets, List<State> states)
        {
            foreach(Tweet tweet in tweets)
            {
                IsInside(tweet, states);
            }
        }

        private void IsInside(Tweet tweet, List<State> states)
        {
            foreach (State state in states)
            {
                PointLatLng point = new PointLatLng(tweet.Coordinates.Latitude, tweet.Coordinates.Longitude);

                var polygon = Polygon(state);
                if(polygon.IsInside(point))
                {
                    tweet.Location = state.Name;
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
