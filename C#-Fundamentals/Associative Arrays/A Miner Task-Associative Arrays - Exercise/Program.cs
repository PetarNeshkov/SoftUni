using System;
using System.Collections.Generic;

namespace A_Miner_Task_Associative_Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>();
            string input = " ";
            while ((input = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!items.ContainsKey(input))
                {
                    items.Add(input, quantity);
                }
                else
                {
                    items[input] += quantity;
                }
            }
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
