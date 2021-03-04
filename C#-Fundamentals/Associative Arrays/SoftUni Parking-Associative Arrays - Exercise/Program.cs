using System;
using System.Collections.Generic;

namespace SoftUni_Parking_Associative_Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            Dictionary<string, string> output = new Dictionary<string,string>();
            for (int i = 0; i < counter; i++)
            {
                string[] input = Console.ReadLine().Split();
                string action = input[0];
                string name = input[1];
                if (action=="register")
                {
                string licensePlate = input[2];
                    if (!output.ContainsKey(name))
                    {
                        output.Add(name, licensePlate);
                        Console.WriteLine($"{name} registered {licensePlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                }
                else if (action=="unregister")
                {
                    if (!output.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        output.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }
            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
