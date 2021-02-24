using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers_Associative_Arrays__Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> counter = new Dictionary<double, int>();
            double[] numbers =Console.ReadLine().Split().Select(double.Parse).ToArray();
            foreach (var item in numbers)
            {
                if (!counter.ContainsKey(item))
                {
                    counter.Add(item, 1);
                }
                else
                {
                    counter[item]++;
                }
            }
            foreach (var item in counter.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
