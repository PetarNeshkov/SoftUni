using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> dc = new Dictionary<string, List<decimal>>();
            int counter = int.Parse(Console.ReadLine());
            for (int i = 0; i < counter; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);
                if (!dc.ContainsKey(name))
                {
                    dc.Add(name, new List<decimal>());
                }
                dc[name].Add(grade);
            }
            foreach (var item in dc)
            {
                decimal avg = item.Value.Average();
                Console.Write($"{item.Key} -> ");
                foreach (var avgs in item.Value)
                {
                    Console.Write($"{avgs:F2} ");
                }
                Console.Write($"(avg: {avg:F2})");
                Console.WriteLine();
            }
        }
    }
}
