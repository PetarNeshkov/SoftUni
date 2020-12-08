using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Numerics;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = 0;
            bool toe = false;
            for (int ch = 1; ch <= counter; ch++)
            {
                temp = ch;
                while (temp != 0)
                {
                    sum += temp % 10;
                    temp = temp / 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {

                    Console.WriteLine($"{ch} -> True");
                }
                else
                {
                    Console.WriteLine($"{ch} -> False");
                }
                sum = 0;
            }
        }
    }
}