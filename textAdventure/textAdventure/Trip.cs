using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using textAdventure;

namespace TextAdventure
{
    class Trip : Flow1

    {
        public static  string[] Trip2 { get; set; }
        public static void ListTrip()
        {

            var trip1 = new List<string>();//crates new list trip1
            trip1.Add("Danali National Park");
            trip1.Add("Istanbul,Bagan");
            trip1.Add("Sail the Caribbean");
            trip1.Add("Holi Festival(India)");//adds elements to list trip1
            trip1.Add("Great Barrier Reef");//<----------------------------
            trip1.Add("Paris,France");
            trip1.Add("Kyoto,Japan");
            trip1.Add("Chicago");
            trip1.Add("Drakensberg,South Africa");
            trip1.Add("Buenos Aires");
            trip1.Add("Forbidden City(Beijing,)");
            trip1.Add("U.S. Highway 1");
            trip1.Add("New Orleans Jazz Fest");
            trip1.Add("Wimbledon(London)");
            trip1.Add("Gorrila trakking(Rwanda)");
            trip1.Add("Bali Indonesia");
            trip1.Add("See the Northern Lights(Alaska)");

           string[] Trip2 = trip1.ToArray();//coverts list to array
                                      

            Random rand = new Random();
            int index = rand.Next(Trip2.Count());

            Console.WriteLine($"{Flow1.Friend} leads you to safety, you decide you need to get away to reflect"); 
              Console.WriteLine($"and go on a {Trip2[index]} trip to relax from the ruff life");  

        }
            
            
            
            
            
            
            
            
            
            
            
            
    }
}
