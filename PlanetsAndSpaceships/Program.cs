using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            Console.WriteLine("First planetlist");
            foreach (var planet in planetList)
            {
                Console.Write($"{planet}, ");
            }
            Console.WriteLine();

            // Added Jupiter and Saturn to the list
            planetList.Add("Jupitar");
            planetList.Add("Saturn");

            List<string> lastTwoPlanet = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastTwoPlanet);
            Console.WriteLine("Added Uranus and Neptune to the planetlist");

            foreach (var planet in planetList)
            {
                Console.Write($"{planet}, ");
            }
            Console.WriteLine();

            Console.WriteLine("Added Venus and Earth in the correct location");
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            foreach (var planet in planetList)
            {
                Console.Write($"{planet}, ");
            }
            Console.WriteLine();

            planetList.Add("Pluto");
            var rockyPlanets = planetList.GetRange(0, 4);
            Console.WriteLine("Here are the rocky planets");
            foreach (var rockyplanet in rockyPlanets)
            {
                Console.Write($"{rockyplanet}, ");
            }

            planetList.Remove("Pluto");
            Console.WriteLine();
            Console.WriteLine("Pluto is removed");
            foreach (var planet in planetList)
            {
                Console.Write($"{planet}, ");
            }
            Console.WriteLine();

            var solarSystemProbes = new Dictionary<string, string>();
            solarSystemProbes.Add("Mars", "Viking, Opportunity, Curiosity");
            solarSystemProbes.Add("Venus", "Mariner, Venera");
            solarSystemProbes.Add("Jupiter", "Juno");
            solarSystemProbes.Add("Saturn", "Pioneer, Cassini, Voyager");
            solarSystemProbes.Add("Uranus", "Voyager");
            solarSystemProbes.Add("Neptune", "Voyager");

            foreach (var planet in planetList)
            {
                Console.Write($"Spaceship launched in {planet}: ");
                foreach(var item in solarSystemProbes)
                {
                    if (planet == item.Key)
                    {
                        Console.WriteLine($"{item.Value}");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
