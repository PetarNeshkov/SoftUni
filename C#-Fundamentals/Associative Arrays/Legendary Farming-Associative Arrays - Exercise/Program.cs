using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming_Associative_Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> LegendaryItems = new Dictionary<string, int>();
            Dictionary<string, int> JunkItems = new Dictionary<string, int>();
            LegendaryItems.Add("shards", 0);
            LegendaryItems.Add("fragments", 0);
            LegendaryItems.Add("motes", 0);
            bool br = false;
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                for (int i = 0; i < input.Length - 1; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string item = input[i + 1].ToLower();
                    if (item == "shards" || item == "fragments" || item == "motes")
                    {
                        LegendaryItems[item] += quantity;
                        if (LegendaryItems[item] >= 250 && item == "shards")
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            LegendaryItems[item] -= 250;
                            br = true;
                            break;
                        }
                        else if (LegendaryItems[item] >= 250 && item == "fragments")
                        {
                            Console.WriteLine("Valanyr obtained!");
                            LegendaryItems[item] -= 250;
                            br = true;
                            break;
                        }
                        else if (LegendaryItems[item] >= 250 && item == "motes")
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            LegendaryItems[item] -= 250;
                            br = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!JunkItems.ContainsKey(item))
                        {
                            JunkItems.Add(item, quantity);
                        }
                        else
                        {
                            JunkItems[item] += quantity;
                        }
                    }
                }
                if (br)
                {
                    break;
                }
            }
            foreach (var item in LegendaryItems.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in JunkItems.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
