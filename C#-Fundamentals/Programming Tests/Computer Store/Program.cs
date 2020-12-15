using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;
            double taxes = 0;
            double totalSum = 0;

            while (true)
            {
                if (input == "special" || input == "regular")
                {
                    break;
                }
                double number = double.Parse(input);
                if (number >= 0)
                {
                    sum += number;
                    taxes += number * 0.20;
                }
                else
                {
                    Console.WriteLine("Invalid price!");
                }
                input = Console.ReadLine();
            }
            totalSum = sum + taxes;
            if (sum == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            else if (input == "special")
            {
                totalSum -= totalSum * 0.10;

            }
            Console.WriteLine($"Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {sum:F2}$");
            Console.WriteLine($"Taxes: {taxes:F2}$");
            Console.WriteLine($"-----------");
            Console.WriteLine($"Total price: {totalSum:F2}$");

        }
    }
}