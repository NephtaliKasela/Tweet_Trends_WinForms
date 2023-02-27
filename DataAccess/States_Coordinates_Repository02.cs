using System.Collections;
using BusinessLogic;
using BusinessLogic.Interfaces;
using Newtonsoft.Json;

namespace DataAccess
{
    public class States_Coordinates_Repository02 : IState_Repository
    {
        List<State> states = new List<State>();
        public List<State> Read_States_Coordinates(string path)
        {
            // Open the Json file and read all data
            string strJsonFile = File.ReadAllText(path);
            var states_coordinates = JsonConvert.DeserializeObject<IList>(strJsonFile);

            for(int i = 0; i < states_coordinates.Count; i++)
            {
                State state = new State();

                var state_coordinates = JsonConvert.DeserializeObject<IDictionary>(states_coordinates[i].ToString());

                // Get the state name and its coordinates into the dictionary

                // Get the state name
                state.Name = state_coordinates["name"].ToString();
                state.Stusab = state_coordinates["stusab"].ToString();
                state.Rank = Convert.ToInt32(state_coordinates["state"].ToString());

                // Extract the state coordinates
                var coord01 = JsonConvert.DeserializeObject<IDictionary>(state_coordinates["st_asgeojson"].ToString());
                var coord02 = JsonConvert.DeserializeObject<IDictionary>(coord01["geometry"].ToString());
                var coord03 = JsonConvert.DeserializeObject<IList>(coord02["coordinates"].ToString());

                foreach (IList coord in coord03)
                {
                    if(coord03.Count == 1)
                    {
                        foreach (IList latitudeAndLongitude in coord)
                        {
                            Console.WriteLine(latitudeAndLongitude[0].ToString());
                            Console.WriteLine(latitudeAndLongitude[1].ToString());
                            
                            // Check if the length of the list is equal to 2
                            // If yes, that means it is not an island, but a concrete state
                            if (latitudeAndLongitude.Count == 2)
                            {
                                Geographic_Coordinates geoCoordinates = new Geographic_Coordinates();
                                geoCoordinates.Latitude = Convert.ToDouble(latitudeAndLongitude[0]);
                                geoCoordinates.Longitude = Convert.ToDouble(latitudeAndLongitude[1]);
                                state.Coordinates.Add(geoCoordinates);
                            }
                            Console.WriteLine();
                            
                        }

                    }
                    Console.WriteLine(coord.Count.ToString());


                }
                Console.WriteLine("----------------------------\n");
                states.Add(state);
            }
            return states;
        }
    }
}