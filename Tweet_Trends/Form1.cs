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

            //// Get all states (Wrong states)
            //listBox1.Items.Add("Get States_Coordinates starts...");
            //States_Coordinates_Repository coord01 = new States_Coordinates_Repository();
            //List<State> states01 = coord01.Read_States_Coordinates("States/states.json");
            //listBox1.Items.Add(states01.Count.ToString());
            //listBox1.Items.Add("Get States_Coordinates ends...");

            //// Check the location of the tweet : Find the state name where the tweet was tweeted (With wrong states coordinates)
            //listBox1.Items.Add("Check location of tweet starts...");
            //Check_Tweet_Location chkL01 = new Check_Tweet_Location();
            //chkL01.Check_Location(twt, states01, listBox1);
            //listBox1.Items.Add("Check location of tweet ends...");


            // Get all states (Right states)
            listBox1.Items.Add("Get States_Coordinates starts...");
            States_Coordinates_Repository02 coord02 = new States_Coordinates_Repository02();
            List<State> states02 = coord02.Read_States_Coordinates("States/us-state-boundaries.json");
            listBox1.Items.Add(states02.Count.ToString());
            listBox1.Items.Add("Get States_Coordinates ends...");

            // Check the location of the tweet : Find the state name where the tweet was tweeted (With right states coordinates)
            listBox1.Items.Add("Check location of tweet starts...");
            Check_Tweet_Location chkL02 = new Check_Tweet_Location();
            chkL02.Check_Location(twt, states02, listBox1);
            listBox1.Items.Add("Check location of tweet ends...");

            listBox1.Items.Add(" ");

            // Print location of tweets
            listBox1.Items.Add("Print location of tweet starts...");
            Print_Tweet_Location printL = new Print_Tweet_Location();
            printL.Print_Location(twt, gmcMap);
            listBox1.Items.Add("Print location of tweet ends...");

            ////Print location of state
            //listBox1.Items.Add("Print location of state starts...");
            //print_State_Location stateL = new print_State_Location();
            //stateL.Print_Location(states01, gmcMap);
            //listBox1.Items.Add("Print location of state ends...");

            //Print location of state
            listBox1.Items.Add("Print location of state starts...");
            print_State_Location stateL = new print_State_Location();
            stateL.Print_Location(states02, gmcMap);
            listBox1.Items.Add("Print location of state ends...");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gmcMap.ShowCenter = false;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Test();
        }
    }
}