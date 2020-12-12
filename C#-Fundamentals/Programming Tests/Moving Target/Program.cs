using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> MovingTarget = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = "";
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split();
                string action = commands[0];
                int index = int.Parse(commands[1]);
                int Power = int.Parse(commands[2]);
                if (action == "Shoot")
                {
                    if (index >= 0 && index < MovingTarget.Count)
                    {
                        MovingTarget[index] -= Power;
                        if (MovingTarget[index] <= 0)
                        {
                            MovingTarget.RemoveAt(index);
                        }
                    }
                }
                else if (action == "Add")
                {
                    if (index >= 0 && index < MovingTarget.Count)
                    {
                        MovingTarget.Insert(index, Power);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid placement!");
                    }
                }
                else if (action == "Strike")
                {
                    if (index - Power < 0 || index + Power >= MovingTarget.Count)
                    {
                        Console.WriteLine("Strike missed!");
                    }
                    else
                    {
                        MovingTarget.RemoveRange(index - Power, Power * 2 + 1);
                    }
                }
            }
            Console.WriteLine(String.Join("|", MovingTarget));
        }
    }
}