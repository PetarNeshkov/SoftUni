﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                int sum = 0;
                int currentDigit = i;
                while (currentDigit != 0)
                {
                    sum += currentDigit % 10;
                    currentDigit /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else Console.WriteLine($"{i} -> False");
            }
        }
    }
}