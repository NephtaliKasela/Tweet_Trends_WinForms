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
            StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] details = line.Split(',');

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
                    //Console.WriteLine($"{details[0]} = {details[1]}");
                }
            }
            return sentiments;
        }
    }
}
