using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = input * i;
                Console.WriteLine($"{input} X {i} = {sum}");
            }
        }
    }
}
