using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<separator>[:]{2}|[*]{2})(?<name>[A-Z][a-z]{2,})\1";
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(input);
            BigInteger coolnes = 1;
            string digitPattern = @"\d+";
            Regex digitRegex = new Regex(digitPattern);
            var secondMatch = digitRegex.Matches(input);
            List<string> emojis = new List<string>();
            foreach (Match numbers in secondMatch)
            {
                string number = numbers.Value;
                for (int i = 0; i < number.Length; i++)
                {
                    int currentNumber = int.Parse(number[i].ToString());
                    coolnes *= currentNumber;
                }
            }
            foreach (Match item in matches)
            {
                BigInteger sum = 0;
               string currentMatch = item.Groups["name"].Value;
                for (int i = 0; i < currentMatch.Length; i++)
                {
                    sum += currentMatch[i];
                }
                if (sum > coolnes)
                {
                    emojis.Add(item.Value);
                }
            }
            Console.WriteLine($"Cool threshold: {coolnes}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            Console.WriteLine(String.Join(Environment.NewLine, emojis));
        }
    }
}
