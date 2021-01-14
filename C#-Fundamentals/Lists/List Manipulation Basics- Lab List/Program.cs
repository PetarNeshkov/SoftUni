using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _0_4TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                if (command[0] == "Add")
                {
                    int index = int.Parse(command[1]);
                    Add(list, index);
                }
                else if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);
                    Remove(list, index);
                }
                else if (command[0] == "RemoveAt")
                {
                    int index = int.Parse(command[1]);
                    RemoveAt(list, index);
                }
                else if (command[0] == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    Insert(list, number, index);
                }

            }

            Console.WriteLine(String.Join(" ", list));
            static void Add(List<int> list, int index)
            {
                list.Add(index);
            }
            static void Remove(List<int> list, int index)
            {
                list.Remove(index);
            }
            static void RemoveAt(List<int> list, int index)
            {
                list.RemoveAt(index);
            }
            static void Insert(List<int> list, int index, int number)
            {
                list.Insert(number, index);
            }
        }
    }
}