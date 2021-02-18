using System;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            double Totalsum = 0;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                string pattern = @"%([A-Z][a-z]+)%[^|$%.]*<(\w+)>[^|$%.]*\|(\d+)\|[^|$%.]*?(\d+?\.*?\d*)\$";
                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);
                if (match.Success)
                {
                    double sum = 0;
                    string customer = match.Groups[1].Value;
                    string product = match.Groups[2].Value;
                    int count = int.Parse(match.Groups[3].Value);
                    double price = double.Parse(match.Groups[4].Value);
                    sum = price * count;
                    Totalsum += sum;
                    Console.WriteLine($"{customer}: {product} - {sum:F2}");
                }
            }
            Console.WriteLine($"Total income: {Totalsum:F2}");
        }
    }
}
