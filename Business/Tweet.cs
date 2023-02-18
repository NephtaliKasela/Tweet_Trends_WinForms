namespace BusinessLogic
{
    public class Tweet
    {
        public Geographic_Coordinates Coordinates { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public List<string> Message { get; set; }
        public double Sentiment { get; set; }

        public Tweet()
        {
            Coordinates = new Geographic_Coordinates();
        }
    }
}