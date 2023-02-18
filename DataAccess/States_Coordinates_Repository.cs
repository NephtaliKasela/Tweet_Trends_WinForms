using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using BusinessLogic;

namespace DataAccess
{
    public class States_Coordinates_Repository
    {
        List<State> states = new List<State>();
        public List<State> Read_States_Coordinates(string path)
        {
            string strJsonFile = File.ReadAllText(path);
            var states_coordinates = JsonConvert.DeserializeObject<IDictionary>(strJsonFile);

            foreach (DictionaryEntry nameAndValues in states_coordinates)
            {
                State state = new State();
                state.Name = nameAndValues.Key.ToString();

                //Console.WriteLine($"{dic.Key}");
                string str = nameAndValues.Value.ToString();
                var coordinates = JsonConvert.DeserializeObject<IList>(str);
                foreach (IList coord in coordinates)
                {
                    //Console.WriteLine($"--{coord.Count}--");
                    foreach (IList latitudeAndLongitude in coord)
                    {
                        // Check if the length of the list is equal to 2
                        // If yes, that means it is not an island, but a concrete state
                        if (latitudeAndLongitude.Count == 2)
                        {
                            Geographic_Coordinates geoCoordinates = new Geographic_Coordinates();
                            geoCoordinates.Latitude = Convert.ToDouble(latitudeAndLongitude[0].ToString());
                            geoCoordinates.Longitude = Convert.ToDouble(latitudeAndLongitude[1].ToString());
                            state.Coordinates.Add(geoCoordinates);

                            //Console.WriteLine($"--{latitudeAndLongitude.Count}--");
                            //Console.WriteLine($"{latitudeAndLongitude}");
                        }
                    }
                    //Console.WriteLine($"----------------");
                }
                states.Add(state);
            }
            return states;
        }
    }
}
