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

            List<double> list = Console.ReadLine().Split().Select(double.Parse).ToList();

            SumAdjacentEqualNumbers(list);
        }
        static void SumAdjacentEqualNumbers(List<double> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    list[i] += list[i + 1];
                    list.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(String.Join(" ", list));
        }

    }
}