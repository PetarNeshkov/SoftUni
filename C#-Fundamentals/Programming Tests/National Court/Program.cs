using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmpleyee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int MaxWork = firstEmployee + secondEmpleyee + thirdEmployee;
            int peopleCount = int.Parse(Console.ReadLine());
            int hours = 0;
            int sum = 0;
            while (sum < peopleCount)
            {
                hours++;
                sum += MaxWork;
                if (hours % 4 == 0)
                {
                    sum -= MaxWork;
                    continue;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}