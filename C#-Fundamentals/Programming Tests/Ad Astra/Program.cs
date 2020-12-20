using System;
using System.Text.RegularExpressions;

namespace Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<separator>\||\#{1})(?<word>[A-Za-z\s]+)\1(?<date>[\d]{2}\/[\d]{2}\/[\d]{2})\1(?<calories>[\d]+)\1";
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(input);
            int days = 0;
            foreach (Match item in matches)
            {
                days += int.Parse(item.Groups["calories"].Value);
            }
            days /= 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match item in matches)
            {
                string name = item.Groups["word"].Value;
                string expDate = item.Groups["date"].Value;
                int calories = int.Parse(item.Groups["calories"].Value);
                Console.WriteLine($"Item: {name}, Best before: {expDate}, Nutrition: {calories}");
            }
        }
    }
}
