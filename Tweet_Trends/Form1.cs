using BusinessLogic;
using DataAccess;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Tweet_Trends
{
    public partial class Form1 : Form
    {
        private List<PointLatLng> _points = new List<PointLatLng>();
        public Form1()
        {
            InitializeComponent();
            //Test();
            
        }

        public void Test()
        {
            //Console.WriteLine("Hello World!");
            listBox1.Items.Add("Hello World!");
            Tweet_Repository Tweets = new Tweet_Repository();
            List<Tweet> twt = Tweets.ReadTweets("family_tweets2014.txt");
            //Console.WriteLine($"{twt.Count}");
            //Console.WriteLine($"{twt[0].Coordinates.Latitude}");
            //Console.WriteLine($"{twt[0].Coordinates.Longitude}");

            Sentiment_Repository sentiments = new Sentiment_Repository();
            List<Sentiment> sentmt = sentiments.ReadSentiments("sentiments.csv");
            //Console.WriteLine($"{sentmt.Count}");
            listBox1.Items.Add(sentmt.Count.ToString());

            Check_Sentiment chkSentiment = new Check_Sentiment();
            chkSentiment.Check(twt, sentmt);

            foreach (Tweet t in twt)
            {
                //Console.WriteLine($"{t.Sentiment}");
                listBox1.Items.Add(t.Sentiment.ToString());
            }

            //States_Coordinates_Repository coor = new States_Coordinates_Repository();
            //List<State> states = coor.Read_States_Coordinates("states.json");

            //foreach(State st in states)
            //{
            //    Console.WriteLine($"{st.Name}");
            //    foreach(Geographic_Coordinates geoc in st.Coordinates)
            //    {
            //        Console.WriteLine($"{geoc.Latitude}");
            //        Console.WriteLine($"{geoc.Longitude}");
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine($"-------------------------");
            //}
        }

        private void btnLoadIntoMap_Click(object sender, EventArgs e)
        {
            gmcMap.DragButton = MouseButtons.Left;
            gmcMap.MapProvider = GMapProviders.GoogleMap;
            double lat = Convert.ToDouble(txtbxLatitude.Text); 
            double longt = Convert.ToDouble(txtbxLongitude.Text);
            //gmcMap.Position = new GMap.NET.PointLatLng(lat, longt);
            gmcMap.Position = new PointLatLng(lat, longt);
            gmcMap.MinZoom = 5;       // Minimum zoom level
            gmcMap.MaxZoom = 100;     // Maximum zoom level
            gmcMap.Zoom = 10;         // Current zoom level

            PointLatLng points = new PointLatLng(lat, longt);

            // Normal marker
            GMapMarker marker = new GMarkerGoogle(points, GMarkerGoogleType.red);

            // Create custom marker
            //Bitmap bmpMarker = (Bitmap)Image.FromFile("Images/Flag-of-Congo-11.png");
            //GMapMarker marker = new GMarkerGoogle(points, bmpMarker);

            // Create an Overlay
            GMapOverlay markers = new GMapOverlay("markers");

            // Add all available markers to that Overlay
            markers.Markers.Add(marker);

            // Cover map with Overlay
            gmcMap.Overlays.Add(markers);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gmcMap.ShowCenter = false;
        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            double lat = Convert.ToDouble(txtbxLatitude.Text);
            double longt = Convert.ToDouble(txtbxLongitude.Text);
            PointLatLng p = new PointLatLng(lat, longt);
            _points.Add(p);
        }

        private void btnGetRoute_Click(object sender, EventArgs e)
        {
            var route = GoogleMapProvider.Instance.GetRoute(_points[0], _points[1], false, false, 14);
            var r = new GMapRoute(route.Points, "My route") { Stroke = new Pen(Color.Red, 5)};

            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            gmcMap.Overlays.Add(routes);

            // get the distance
            lblDistance.Text = route.Distance + " Km";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _points.Clear();
        }

        private void btnAddPolygon_Click(object sender, EventArgs e)
        {
            var polygon = new GMapPolygon(_points, "My area")
            {
                Stroke = new Pen(Color.DarkViolet, 2),
                Fill = new SolidBrush(Color.BurlyWood),
            };
            var polygons = new GMapOverlay("polygons");
            polygons.Polygons.Add(polygon);
            gmcMap.Overlays.Add(polygons);


        }
    }
}