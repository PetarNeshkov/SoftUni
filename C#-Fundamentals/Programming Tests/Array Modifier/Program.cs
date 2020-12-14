using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split();
                string action = commands[0];
                if (action == "swap")
                {
                    int index1 = int.Parse(commands[1]);
                    int index2 = int.Parse(commands[2]);
                    int c = array[index1];
                    array[index1] = array[index2];
                    array[index2] = c;
                }
                else if (action == "multiply")
                {
                    int index1 = int.Parse(commands[1]);
                    int index2 = int.Parse(commands[2]);
                    array[index1] *= array[index2];
                }
                else if (action == "decrease")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] -= 1;
                    }
                }
            }
            Console.WriteLine(String.Join(", ", array));
        }
    }
}