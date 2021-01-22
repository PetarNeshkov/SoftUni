using System;
using System.Collections.Generic;
using System.Linq;

namespace Train_Lists_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Passengers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string input = string.Empty;
            while ((input=Console.ReadLine())!="end")
            {
                string[] commands = input.Split();
                string action = commands[0];
                if (action=="Add")
                {
                    int passenger = int.Parse(commands[1]);
                    Passengers.Add(passenger);
                }
                else
                {
                    int passenger = int.Parse(commands[0]);
                    for (int i = 0; i < Passengers.Count; i++)
                    {
                        if (Passengers[i]+passenger<=maxCapacity)
                        {
                            Passengers[i] += passenger;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(" ",Passengers));
        }
    }
}
