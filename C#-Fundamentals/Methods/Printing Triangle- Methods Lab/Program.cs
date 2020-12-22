using System;

namespace Printing_Triangle__Methods_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
        }
        static void PrintTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                PrintNumbersFrom1(i);
            }
            for (int i = number - 1; i >= 1; i--)
            {
                PrintNumbersFrom1(i);
            }
        }
        static void PrintNumbersFrom1(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
