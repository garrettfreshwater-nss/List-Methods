using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {

        static void Main (string[] args)
        {

            List<string> planetList = new List<string> () { "Mercury", "Mars", };

            planetList.Add ("Jupiter");
            planetList.Add ("Saturn");

            List<string> lastPlanetList = new List<string> () { "Uranus", "Neptune", };

            planetList.AddRange (lastPlanetList);

            planetList.Insert (3, "Earth");
            planetList.Insert (4, "Venus");

            planetList.Add ("Pluto");

            List<string> rockyPlanets = planetList.GetRange (0, 4);

            planetList.Remove ("Pluto");

            foreach (string planet in planetList)
            {
                Console.WriteLine (planet);
            }

        }
    }
}