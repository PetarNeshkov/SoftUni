using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;
            int check = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                    check++;
                    if (check == numbers)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}