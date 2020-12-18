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
            string input = Console.ReadLine();
            string pattern = @"(?<separator>@|#{1})(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1";
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(input);
            List<string> matched = new List<string>();
            if (matches.Count > 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }
            foreach (Match item in matches)
            {
                string firstWord = item.Groups["firstWord"].Value;
                string secondWord = item.Groups["secondWord"].Value;
                char[] reversedSec = secondWord.Reverse().ToArray();
                string reversed = new string(reversedSec);
                if (firstWord == reversed)
                {
                    string stringToAdd = firstWord + " <=> " + secondWord;
                    matched.Add(stringToAdd);
                }
            }
            if (matched.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                Console.Write(String.Join(", ", matched));
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
