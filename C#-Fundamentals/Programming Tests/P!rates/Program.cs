using System;
using System.Collections.Generic;
using System.Linq;

namespace P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> dc = new Dictionary<string, List<int>>();
            string input = "";
            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] information = input.Split("||");
                string town = information[0];
                int population = int.Parse(information[1]);
                int gold = int.Parse(information[2]);
                if (dc.ContainsKey(town))
                {
                    dc[town][0] += population;
                    dc[town][1] += gold;
                }
                else
                {
                    dc.Add(town, new List<int>() { population, gold });
                }
            }
            while ((input = Console.ReadLine()) != "End")
            {
                string[] information = input.Split("=>");
                string action = information[0];
                if (action == "Plunder")
                {
                    string town = information[1];
                    int population = int.Parse(information[2]);
                    int gold = int.Parse(information[3]);
                    dc[town][0] -= population;
                    dc[town][1] -= gold;
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {population} citizens killed.");
                    if (dc[town][0] <= 0 || dc[town][1] <= 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        dc.Remove(town);
                    }
                }
                else if (action == "Prosper")
                {
                    string town = information[1];
                    int gold = int.Parse(information[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                    else
                    {
                        dc[town][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {dc[town][1]} gold.");
                    }
                }
            }
            if (dc.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {dc.Count} wealthy settlements to go to:");
                foreach (var item in dc.OrderByDescending(gold => gold.Value[1])
                    .ThenBy(name => name.Key))
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
