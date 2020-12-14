using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> Numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            double avg = 0;
            avg = Numbers.Sum() * 1.0 / Numbers.Count * 1.0;
            List<int> newNumbers = new List<int>();
            for (int i = 0; i < Numbers.Count; i++)
            {
                if (Numbers[i] > avg)
                {
                    newNumbers.Add(Numbers[i]);
                }
            }
            if (newNumbers.Count >= 5)
            {
                Console.WriteLine(String.Join(" ", newNumbers.OrderByDescending(x => x).Take(5)));
            }
            else if (newNumbers.Count < 5 && newNumbers.Count != 0)
            {
                Console.WriteLine(String.Join(" ", newNumbers.OrderByDescending(x => x)));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}