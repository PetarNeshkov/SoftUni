using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture_Regular_Expressions___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> furniture = new List<string>();
            double sum = 0;
            string pattern = @">>(?<furniture>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";
            string input = string.Empty;
            while ((input=Console.ReadLine())!="Purchase")
            {
            Regex regex = new Regex(pattern);
            var match= regex.Match(input);
                if (match.Success)
                {
                    furniture.Add(match.Groups["furniture"].Value);
                    sum+=double.Parse(match.Groups["price"].Value)*
                       int.Parse(match.Groups["quantity"].Value);
                }
            }
            Console.WriteLine("Bought furniture:");
            if (furniture.Count > 0)
            {
                Console.WriteLine($"{string.Join(Environment.NewLine, furniture)}");
            }
            Console.WriteLine($"Total money spend: {sum:F2}");
        }
    }
}
