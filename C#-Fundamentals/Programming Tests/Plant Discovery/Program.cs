using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> plantRarity = new Dictionary<string, int>();
            Dictionary<string, List<double>> plantRating = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());
            string input = string.Empty;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[] splitInput = input.Split("<->");
                string plant = splitInput[0];
                int rarity = int.Parse(splitInput[1]);

                if (plantRarity.ContainsKey(plant))
                {
                    plantRarity[plant] = rarity;
                }
                else
                {
                    plantRarity.Add(plant, rarity);
                    plantRating.Add(plant, new List<double>());
                }
            }

            input = string.Empty;

            input = Console.ReadLine();
            while (input != "Exhibition")
            {
                string[] splitInput = input.Split(": ");
                string command = splitInput[0];
                string toSplit = splitInput[1];
                if (command == "Rate")
                {
                    string[] split = toSplit.Split(" - ");
                    string plant = split[0];
                    int rating = int.Parse(split[1]);

                    if (plantRating.ContainsKey(plant))
                    {
                        plantRating[plant].Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command == "Update")
                {
                    string[] split = toSplit.Split(" - ");
                    string plant = split[0];
                    int rarity = int.Parse(split[1]);
                    if (plantRarity.ContainsKey(plant))
                    {
                        plantRarity[plant] = rarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command == "Reset")
                {
                    string plant = toSplit;


                    if (plantRating.ContainsKey(plant))
                    {
                        plantRating[plant].RemoveRange(0, plantRating[plant].Count);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                else
                {
                    Console.WriteLine("error");
                }

                input = Console.ReadLine();
            }

            Dictionary<string, double> averageRating = new Dictionary<string, double>();

            foreach (var item in plantRating)
            {
                if (item.Value.Count > 0)
                {
                    averageRating.Add(item.Key, item.Value.Average());
                }
                else
                {
                    averageRating.Add(item.Key, 0);
                }
            }

            averageRating = averageRating.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            Dictionary<string, List<double>> plantRarityRating = new Dictionary<string, List<double>>();

            foreach (var item in plantRarity.OrderByDescending(x => x.Value))
            {
                foreach (var rating in averageRating.OrderByDescending(x => x.Value))
                {
                    if (item.Key == rating.Key)
                    {
                        plantRarityRating.Add(item.Key, new List<double>());
                        plantRarityRating[item.Key].Add(item.Value);
                        plantRarityRating[item.Key].Add(rating.Value);
                    }
                }

            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var rarity in plantRarityRating.OrderByDescending(x => x.Value[0]).ThenByDescending(x => x.Value[1]))
            {
                Console.WriteLine($"- {rarity.Key}; Rarity: {rarity.Value[0]}; Rating: {rarity.Value[1]:f2}");
            }


        }
    }
}