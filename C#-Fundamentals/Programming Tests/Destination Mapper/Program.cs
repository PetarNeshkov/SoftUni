using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<separator>=|\/{1})(?<word>[A-Z][A-Za-z]{2,})\1";
            int sum = 0;
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(input);
            List<string> destinations = new List<string>();
            foreach (Match item in matches)
            {
                string destination = item.Groups["word"].Value;
                sum += destination.Length;
                destinations.Add(destination);
            }
            Console.WriteLine($"Destinations: {String.Join(", ",destinations)}");
            Console.WriteLine($"Travel Points: {sum}");
        }
    }
}
