using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace DataAccess
{
    public class Sentiment_Repository
    {
        List<Sentiment> sentiments = new List<Sentiment>();
        public List<Sentiment> ReadSentiments(string path)
        {
            // Open the file and get read all data
            StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] details = line.Split(',');

                // Add the word and its value to the list of sentiments
                if (details.Length >= 2)
                {
                    Sentiment sentmt = new Sentiment();
                    try
                    {
                        sentmt.Content = details[0];
                        sentmt.Value = Convert.ToDouble(details[1]);

                        sentiments.Add(sentmt);
                    }
                    catch { }
                }
            }
            return sentiments;
        }
    }
}
