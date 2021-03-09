using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Exam_Results_Associative_Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Dictionary<string, int> names = new Dictionary<string, int>();
            Dictionary<string, int> languages = new Dictionary<string, int>();
            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] commands = input.Split("-");
                string name = commands[0];
                string languageOrBann = commands[1];
                if (languageOrBann != "banned")
                {
                    int points = int.Parse(commands[2]);
                    if (!names.ContainsKey(name))
                    {
                        names.Add(name, points);
                    }
                    else
                    {
                        if (names[name] < points)
                        {
                            names[name] = points;
                        }
                    }
                    if (!languages.ContainsKey(languageOrBann))
                    {
                        languages.Add(languageOrBann, 1);
                    }
                    else
                    {
                        languages[languageOrBann]++;
                    }
                }
                else
                {
                    if (names.ContainsKey(name))
                    {
                        names.Remove(name);
                    }
                }
            }
            Console.WriteLine("Results:");
            foreach (var name in names.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{name.Key} | {name.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in languages.OrderByDescending(x => x.Value).
                ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
