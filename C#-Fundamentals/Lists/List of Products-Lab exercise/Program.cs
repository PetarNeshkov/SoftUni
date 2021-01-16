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
            int index = int.Parse(Console.ReadLine());
            //List<int> list = Console.ReadLine().Split().Select(int
            //  .Parse).ToList();

            ListOfProducts(index);
        }
        static void ListOfProducts(int index)
        {
            List<string> sum = new List<string>();
            for (int i = 0; i < index; i++)
            {
                string product = Console.ReadLine();
                sum.Add(product);
            }
            sum.Sort();
            for (int i = 0; i < sum.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{sum[i]}");

            }
        }
    }
}