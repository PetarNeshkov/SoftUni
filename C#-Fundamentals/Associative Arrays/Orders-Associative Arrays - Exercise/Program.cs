using System;
using System.Collections.Generic;

namespace Orders_Associative_Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> output = new Dictionary<string, List<double>>();
            string input = "";
            while ((input=Console.ReadLine())!="buy")
            {
                string[] information = input.Split();
                string item = information[0];
                double price = double.Parse(information[1]);
                int quantity = int.Parse(information[2]);
                if (!output.ContainsKey(item))
                {
                    output.Add(item,new List<double> { price,quantity});
                }
                else
                {
                    output[item][0] = price;
                    output[item][1] += quantity;
                }
            }
            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0]*item.Value[1]):F2}");
            }
        }
    }
}
