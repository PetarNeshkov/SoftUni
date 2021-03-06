using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy_Associative_Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> data = new Dictionary<string,List<double>>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!data.ContainsKey(name))
                {
                    data.Add(name, new List<double>());
                }
                data[name].Add(grade);
            }
            Dictionary<string,double> Avg =new Dictionary<string, double>();
            foreach (var item in data)
            {
                Avg.Add(item.Key, item.Value.Average());
            }
            foreach (var student in Avg.OrderByDescending(x=>x.Value).Where(x=>x.Value>=4.50))
            {
                Console.WriteLine($"{student.Key} -> {student.Value:F2}");
            }
        }
    }
}
