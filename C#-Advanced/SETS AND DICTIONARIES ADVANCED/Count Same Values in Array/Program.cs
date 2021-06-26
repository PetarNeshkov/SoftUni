using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> dc = new Dictionary<double, int>();
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                double currDigit = input[i];
                if (!dc.ContainsKey(currDigit))
                {
                    dc.Add(currDigit, 1);
                }
                else
                {
                    dc[currDigit]++;
                }
            }
            foreach (var item in dc)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }     
        }
    }
}
