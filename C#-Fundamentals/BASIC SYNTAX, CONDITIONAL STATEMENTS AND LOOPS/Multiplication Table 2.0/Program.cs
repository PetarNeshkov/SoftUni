using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int timesToMultiply = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = timesToMultiply; i <= 10; i++)
            {
                sum = input * i;
                Console.WriteLine($"{input} X {i} = {sum}");
            }
            if (timesToMultiply > 10)
            {
                sum = input * timesToMultiply;
                Console.WriteLine($"{input} X {timesToMultiply} = {sum}");
            }
        }
    }
}