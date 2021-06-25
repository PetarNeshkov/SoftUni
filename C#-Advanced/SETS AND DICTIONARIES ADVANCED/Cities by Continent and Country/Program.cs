using System;
using System.Collections.Generic;

namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string,Dictionary<string, List<string>>>();
            int counter = int.Parse(Console.ReadLine());
            for (int i = 0; i < counter; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string country = input[1];
                string city = input[2];
                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country,new List<string>());
                }
                continents[continent][country].Add(city);
            }
                foreach (var currContinent in continents)
                {
                    Console.WriteLine($"{currContinent.Key}:");
                    foreach (var currCountry in currContinent.Value)
                    {
                        Console.WriteLine($"{currCountry.Key} -> {String.Join(", ",currCountry.Value)}");
                    }
                }
        }
    }
}
