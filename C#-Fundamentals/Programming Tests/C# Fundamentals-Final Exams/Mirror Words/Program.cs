using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<separator>@|#{1})(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1";
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(input);
            List<string> mirrorWords = new List<string>();
            foreach (Match item in matches)
            {
                string firstWord = item.Groups["firstWord"].Value;
                string secondWord = item.Groups["secondWord"].Value;
                char[] reversedChar = secondWord.ToCharArray();
                Array.Reverse(reversedChar);
                string Reversed =  new string(reversedChar);
                string wordToAdd = firstWord + " <=> " + secondWord;
                if (Reversed==firstWord)
                {
                    mirrorWords.Add(wordToAdd);
                }
            }
            if (matches.Count>0)
            {
            Console.WriteLine($"{matches.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }
            if (mirrorWords.Count>0)
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(String.Join(", ",mirrorWords));
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
