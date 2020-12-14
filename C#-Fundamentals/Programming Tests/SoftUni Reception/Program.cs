using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int workingHours = int.Parse(Console.ReadLine());
            int hours = 0;
            int sum = 0;
            while (sum < workingHours)
            {
                sum += firstNumber + secondNumber + thirdNumber;
                hours++;
                if (hours % 4 == 0)
                {
                    sum -= firstNumber + secondNumber + thirdNumber;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}