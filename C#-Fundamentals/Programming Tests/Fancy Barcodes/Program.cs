using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            for (int i = 0; i < counter; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"(?<separator>@#{1,})(?<barcode>[A-Z][A-Za-z\d]{4,}[A-Z])(?<Secondseparator>@#{1,})";
                Regex regex = new Regex(pattern);
                var match = regex.Match(input);
                if (match.Success)
                {
                    string word = match.Groups["barcode"].Value;
                    StringBuilder sb = new StringBuilder();
                    for (int k = 0; k < word.Length; k++)
                    {
                        if (char.IsDigit(word[k]))
                        {
                            sb.Append(word[k]);
                        }
                    }
                    if (sb.Length > 0)
                    {
                        Console.WriteLine($"Product group: {sb}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
