namespace BusinessLogic
{
    public class Tweet
    {
        public string Location { get; set; }
        public Geographic_Coordinates Coordinates { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public List<string> Message { get; set; }
        public double Sentiment { get; set; }

        public Tweet()
        {
            this.Coordinates = new Geographic_Coordinates();
        }
    }
}