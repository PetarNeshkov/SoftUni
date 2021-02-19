using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race_Regular_Expressions___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> namesAndKms = new Dictionary<string, int>();
            string[] contestants = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string namePattern = "[A-Za-z]";
            string digitPattern = "[0-9]";
            string input = "";
            while ((input = Console.ReadLine()) != "end of race")
            {
                var matchesName = Regex.Matches(input, namePattern);
                var matchesDigits = Regex.Matches(input, digitPattern);

                var name=String.Concat(matchesName);
                var sum = matchesDigits.Select(x=>int.Parse(x.Value)).Sum();
                if (contestants.Contains(name))
                {
                    if (namesAndKms.ContainsKey(name))
                    {
                        namesAndKms[name] += sum;
                    }
                    else
                    {
                        namesAndKms.Add(name,sum);
                    }
                }
            }
            var sorted = namesAndKms.OrderByDescending(x => x.Value).Select(x=>x.Key).Take(3).ToList();
            Console.WriteLine($"1st place: {sorted[0]}");
            Console.WriteLine($"2nd place: {sorted[1]}");
            Console.WriteLine($"3rd place: {sorted[2]}");

        }
    }
}
