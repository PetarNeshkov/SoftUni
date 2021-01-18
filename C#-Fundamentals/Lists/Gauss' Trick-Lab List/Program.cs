using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _0_4TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = Console.ReadLine().Split().Select(int
                .Parse).ToList();

            Gauss(list);
        }
        static void Gauss(List<int> list)
        {
            List<int> sum = new List<int>();
            for (int i = 0; i < list.Count / 2; i++)
            {
                sum.Add(list[i] + list[list.Count - 1 - i]);
            }
            if (list.Count % 2 == 1)
            {
                sum.Add(list[list.Count / 2]);
            }
            Console.WriteLine(String.Join(" ", sum));
        }

    }
}