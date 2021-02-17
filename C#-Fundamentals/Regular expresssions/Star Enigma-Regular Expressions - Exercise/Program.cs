using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Star_Enigma_Regular_Expressions___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var counterA = 0;
            var counterD = 0;
            var listAttackedPlanets = new List<string>();
            var listDestroyedPlanets = new List<string>();
            int numberOfMessages = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfMessages; i++)
            {
                string input = Console.ReadLine();
                string patternKey = @"[sStTAaRr]";

                var matches = Regex.Matches(input, patternKey);
                int count = matches.Count;
                string decryptedMessage = string.Empty;
                foreach (var character in input)
                {
                    decryptedMessage += (char)(character - count);
                }
                string pattern = @"[^@!\-:>]*@(?<planet>[a-zA-z]+)[^@!\-:>]*:[^@!-:>]*(?<populationCount>\d+)[^@!\-:>]*![^@!\-:>]*(?<attackType>[AD])![^@\-!:>]->(?<soldierCount>\d+)[^@!\-:>]*";
                var matchedMessage = Regex.Match(decryptedMessage, pattern);
                if (matchedMessage.Success)
                {
                    if (matchedMessage.Groups["attackType"].Value == "A")
                    {
                        counterA++;
                        var attackedPlanets = $"-> {matchedMessage.Groups["planet"].Value}";
                        listAttackedPlanets.Add(attackedPlanets);
                    }
                    else
                    {
                        counterD++;
                        var destroyedPlanets = $"-> {matchedMessage.Groups["planet"].Value}";
                        listDestroyedPlanets.Add(destroyedPlanets);
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {counterA}");
            if (counterA != 0)
            {
                Console.WriteLine(string.Join("\n", listAttackedPlanets.OrderBy(x => x)));
            }
            Console.WriteLine($"Destroyed planets: {counterD}");
            Console.WriteLine(string.Join("\n", listDestroyedPlanets.OrderBy(x => x)));
        }
    }
}
