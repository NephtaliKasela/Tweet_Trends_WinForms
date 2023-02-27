using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using BusinessLogic;
using BusinessLogic.Interfaces;

namespace DataAccess
{
    public class States_Coordinates_Repository : IState_Repository
    {
        List<State> states = new List<State>();
        public List<State> Read_States_Coordinates(string path)
        {
            // Open the Json file and read all data
            string strJsonFile = File.ReadAllText(path);
            var states_coordinates = JsonConvert.DeserializeObject<IDictionary>(strJsonFile);

            // Get the state name and its coordinates into the dictionary
            foreach (DictionaryEntry nameAndValues in states_coordinates)
            {
                State state = new State();
                state.Name = nameAndValues.Key.ToString();

                string str = nameAndValues.Value.ToString();
                var coordinates = JsonConvert.DeserializeObject<IList>(str);
                foreach (IList coord in coordinates)
                {
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
                        }
                    }
                }
                states.Add(state);
            }
            return states;
        }
    }
}
