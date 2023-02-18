using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace DataAccess
{
    public class Check_Sentiment
    {
        // Check if a message contains a sentiment.
        public void Check(List<Tweet> tweets, List<Sentiment> sentiments)
        {
            //int c = 0;
            foreach (Tweet twt in tweets)
            {
                foreach (Sentiment sentiment in sentiments)
                {
                    for (int i = 0; i < twt.Message.Count; i++)
                    {
                        if (twt.Message[i].ToLower() == sentiment.Content.ToLower())
                        {
                            twt.Sentiment += sentiment.Value;
                            //c += 1;
                        }
                    }
                }
                //Console.WriteLine($"{twt.Sentiment}");
            }
            //Console.WriteLine($"Total : {c}");
        }
    }
}
