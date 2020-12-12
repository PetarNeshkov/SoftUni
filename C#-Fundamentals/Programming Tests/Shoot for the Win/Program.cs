using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Targets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = "";
            int counter = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                int index = int.Parse(input);
                if (index >= 0 && index < Targets.Length)
                {
                    int CurrentNumber = Targets[index];
                    for (int i = 0; i < Targets.Length; i++)
                    {
                        if (Targets[i] != -1)
                        {
                            if (CurrentNumber < Targets[i])
                            {
                                Targets[i] -= CurrentNumber;
                            }
                            else
                            {
                                Targets[i] += CurrentNumber;
                            }
                        }
                    }
                    Targets[index] = -1;
                    counter++;
                }
            }
            Console.WriteLine($"Shot targets: {counter} -> {string.Join(" ", Targets)}");
        }
    }
}