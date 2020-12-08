using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal dollar = pounds * (decimal)1.31;
            Console.WriteLine($"{dollar:F3}");
        }
    }
}