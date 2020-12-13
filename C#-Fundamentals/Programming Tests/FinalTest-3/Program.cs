using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int unlikeCount = 0;
            Dictionary<string, List<string>> dc = new Dictionary<string, List<string>>();
            string input = "";
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] tokens = input.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];
                string guest = tokens[1];
                string meal = tokens[2];
                if (action == "Like")
                {
                    if (!dc.ContainsKey(guest))
                    {
                        dc.Add(guest, new List<string>());
                    }
                    if (!dc[guest].Contains(meal))
                    {
                        dc[guest].Add(meal);
                    }
                }
                else if (action == "Unlike")
                {
                    if (dc.ContainsKey(guest))
                    {
                        if (dc[guest].Contains(meal))
                        {
                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                            dc[guest].Remove(meal);
                            unlikeCount++;
                        }
                        else
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                }
            }
            foreach (var item in dc.OrderByDescending(meals => meals.Value.Count)
                .ThenBy(names => names.Key))
            {
                var meals = item.Value;
                Console.Write($"{item.Key}: ");
                Console.Write(String.Join(", ", meals));
                Console.WriteLine();

            }
            Console.WriteLine($"Unliked meals: {unlikeCount}");
        }
    }
}