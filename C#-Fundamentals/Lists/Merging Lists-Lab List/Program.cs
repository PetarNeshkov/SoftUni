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

            List<int> list1 = Console.ReadLine().Split().Select(int
                .Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int
               .Parse).ToList();
            MergingList(list1, list2);
        }
        static void MergingList(List<int> list1, List<int> list2)
        {
            List<int> sum = new List<int>();
            int max = Math.Max(list1.Count, list2.Count);
            for (int i = 0; i < max; i++)
            {
                if (list1.Count > i)
                {
                    sum.Add(list1[i]);
                }
                if (list2.Count > i)
                {
                    sum.Add(list2[i]);

                }
            }

            Console.WriteLine(String.Join(" ", sum));
        }

    }
}