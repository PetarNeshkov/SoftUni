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

            ListOfProducts(list);
        }
        static void ListOfProducts(List<int> list)
        {
            List<string> sum = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {

                if (list[i] < 0)
                {
                    list.RemoveAt(i);
                    i = -1;

                }
            }
            list.Reverse();
            if (list.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else Console.WriteLine(String.Join(" ", list));
        }

    }
}