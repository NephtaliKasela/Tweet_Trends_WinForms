using BusinessLogic;
using DataAccess;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using BusinessLogic.Operations;

namespace Tweet_Trends
{
    public partial class Form1 : Form
    {
        private List<PointLatLng> _points = new List<PointLatLng>();
        public Form1()
        {
            InitializeComponent();
        }

        public void Test()
        {
            listBox1.Items.Add("Hello World!");

            // Get all tweets
            listBox1.Items.Add("Get tweets starts...");
            Tweet_Repository Tweets = new Tweet_Repository();
            List<Tweet> twt = Tweets.ReadTweets("Tweets/movie_tweets2014.txt");
            listBox1.Items.Add(twt.Count.ToString());
            listBox1.Items.Add("Get tweets ends...");

            // Get all sentiments
            listBox1.Items.Add("Get sentiment starts...");
            Sentiment_Repository sentiments = new Sentiment_Repository();
            List<Sentiment> sentmt = sentiments.ReadSentiments("Sentiments/sentiments.csv");
            listBox1.Items.Add(sentmt.Count.ToString());
            listBox1.Items.Add("Get sentiment ends...");

            // Check if a message contains a sentiment
            listBox1.Items.Add("Check if sentiment starts...");
            Check_Sentiment chkSentiment = new Check_Sentiment();
            chkSentiment.Check(twt, sentmt);
            listBox1.Items.Add("Check if sentiment ends...");

            // Get all states
            listBox1.Items.Add("Get States_Coordinates starts...");
            States_Coordinates_Repository coor = new States_Coordinates_Repository();
            List<State> states = coor.Read_States_Coordinates("States/states.json");
            listBox1.Items.Add(states.Count.ToString());
            listBox1.Items.Add("Get States_Coordinates ends...");

            // Check the location of the tweet : Find the state name where the tweet was tweeted
            listBox1.Items.Add("Check location of tweet starts...");
            Check_Tweet_Location chkL = new Check_Tweet_Location();
            chkL.Check_Location(twt, states, listBox1);
            listBox1.Items.Add("Check location of tweet ends...");

            listBox1.Items.Add(" ");

            // Print location of tweets
            listBox1.Items.Add("Print location of tweet starts...");
            Print_Tweet_Location printL = new Print_Tweet_Location();
            printL.Print_Location(twt, gmcMap);
            listBox1.Items.Add("Print location of tweet ends...");

            // Print location of state
            listBox1.Items.Add("Print location of state starts...");
            print_State_Location stateL = new print_State_Location();
            stateL.Print_Location(states, gmcMap);
            listBox1.Items.Add("Print location of state ends...");
        }

        private void btnLoadIntoMap_Click(object sender, EventArgs e)
        {
            gmcMap.DragButton = MouseButtons.Left;
            gmcMap.MapProvider = GMapProviders.GoogleMap;
            double lat = Convert.ToDouble(txtbxLatitude.Text); 
            double longt = Convert.ToDouble(txtbxLongitude.Text);

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

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Test();
        }
    }
}