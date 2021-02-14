using System;
using System.Text.RegularExpressions;

namespace Match_Dates_Regular_Expressions___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //string pattern = @"(?<date>[0-9]{2})(.)(?<month>[A-Za-z]{3})\1(?<year>[0-9]{4})";
            MatchCollection dates = Regex.Matches(Console.ReadLine(),@"(?<date>[0-9]{2})(.)(?<month>[A-Za-z]{3})\1(?<year>[0-9]{4})");
            foreach (Match item in dates)
            {
                Console.WriteLine($"Day: {item.Groups["date"]}, Month: {item.Groups["month"]}, Year: {item.Groups["year"]}");
            }
        }
    }
}
