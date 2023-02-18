using BusinessLogic;

namespace DataAccess
{
    public class Tweet_Repository
    {
        List<Tweet> tweets = new List<Tweet>();
        public List<Tweet> ReadTweets(string path)
        {
            StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] details = line.Split('\t');

                if (details.Length >= 4)
                {
                    Tweet twt = new Tweet();
                    // Split the first element in the array 'details' and extract the latitude and the longitude
                    details[0] = details[0].Replace("[", "");
                    details[0] = details[0].Replace("]", "");
                    string[] cordinates = details[0].Split(',');
                    cordinates[0] = cordinates[0].Trim();
                    cordinates[1] = cordinates[1].Trim();

                    // Split the second element in the array 'details' and extract the date and time
                    string[] dateAndTime = details[2].Split();

                    // Clean the message
                    string[] message = details[3].Split();
                    for (int i = 0; i < message.Length; i++)
                    {
                        for (int j = 0; j < message[i].Length; j++)
                        {
                            if (char.IsPunctuation(message[i][j])) message[i] = message[i].Replace(message[i][j].ToString(), "");
                        }
                    }

                    try
                    {
                        twt.Coordinates.Latitude = Convert.ToDouble(cordinates[0]);
                        twt.Coordinates.Longitude = Convert.ToDouble(cordinates[1]);
                        twt.Date = dateAndTime[0];
                        twt.Time = dateAndTime[1];
                        twt.Message = new List<string>();
                        for (int i = 0; i < message.Length; i++) if (message[i] != string.Empty) twt.Message.Add(message[i]);
                        tweets.Add(twt);
                    }
                    catch { }

                    //Console.WriteLine($"{twt.Latitude}");
                    //Console.WriteLine($"{twt.Longitude}");
                    //Console.WriteLine($"{twt.Date}");
                    //Console.WriteLine($"{twt.Time}");
                    //foreach (string s in twt.Message)
                    //{
                    //    Console.WriteLine($"{s}");
                    //}

                    //Console.WriteLine($"-------------------------------\n");
                }
            }
            return tweets;
        }
    }
}