using BusinessLogic;
using DataAccess;

namespace Tweet_Trends
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        public void Test()
        {
            Console.WriteLine("Hello World!");
            Tweet_Repository Tweets = new Tweet_Repository();
            List<Tweet> twt = Tweets.ReadTweets("family_tweets2014.txt");
            //Console.WriteLine($"{twt.Count}");
            //Console.WriteLine($"{twt[0].Coordinates.Latitude}");
            //Console.WriteLine($"{twt[0].Coordinates.Longitude}");

            Sentiment_Repository sentiments = new Sentiment_Repository();
            List<Sentiment> sentmt = sentiments.ReadSentiments("sentiments.csv");
            Console.WriteLine($"{sentmt.Count}");

            Check_Sentiment chkSentiment = new Check_Sentiment();
            chkSentiment.Check(twt, sentmt);

            foreach (Tweet t in twt)
            {
                Console.WriteLine($"{t.Sentiment}");
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
    }
}