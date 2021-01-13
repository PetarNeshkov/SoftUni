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
            bool ischanged = false;
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                ischanged = true;
                string[] command = input.Split();
                if (command[0] == "Contains")
                {
                    ischanged = true;
                    int index = int.Parse(command[1]);
                    Contains(list, index);
                }
                else if (command[0] == "PrintEven")
                {

                    ischanged = true;
                    PrintEven(list);
                }
                else if (command[0] == "PrintOdd")
                {
                    ischanged = true;
                    PrintOdd(list);
                }
                else if (command[0] == "GetSum")
                {
                    ischanged = true;
                    GetSum(list);
                }
                else if (command[0] == "Filter")
                {
                    ischanged = true;
                    string condition = command[1];
                    int number = int.Parse(command[2]);
                    Filter(list, condition, number);
                }
                else if (command[0] == "Add")
                {
                    ischanged = true;
                    int index = int.Parse(command[1]);
                    Add(list, index);
                }
                else if (command[0] == "Remove")
                {
                    ischanged = true;
                    int index = int.Parse(command[1]);
                    Remove(list, index);
                }
                else if (command[0] == "RemoveAt")
                {
                    ischanged = true;
                    int index = int.Parse(command[1]);
                    RemoveAt(list, index);
                }
                else if (command[0] == "Insert")
                {
                    ischanged = true;
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    Insert(list, number, index);
                }
            }
            if (ischanged == false)
            {
                Console.WriteLine(String.Join(" ", list));
            }


        }

        static void Contains(List<int> list, int index)
        {
            if (list.Contains(index))
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No such number");


        }
        static void PrintEven(List<int> list)
        {
            List<int> Even = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    Even.Add(list[i]);
                }
            }
            Console.WriteLine(String.Join(" ", Even));
        }
        static void PrintOdd(List<int> list)
        {
            List<int> odd = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    odd.Add(list[i]);
                }
            }
            Console.WriteLine(String.Join(" ", odd));
        }
        static void GetSum(List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            Console.WriteLine(sum);
        }
        static void Filter(List<int> list, string condition, int number)
        {
            List<int> check = new List<int>();
            if (condition == ">")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] > number)
                    {
                        check.Add(list[i]);
                    }
                }
                Console.WriteLine(String.Join(" ", check));
            }
            else if (condition == "<")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] < number)
                    {
                        check.Add(list[i]);
                    }
                }
                Console.WriteLine(String.Join(" ", check));
            }
            else if (condition == ">=")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] >= number)
                    {
                        check.Add(list[i]);
                    }
                }
                Console.WriteLine(String.Join(" ", check));
            }
            else if (condition == "<=")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] <= number)
                    {
                        check.Add(list[i]);
                    }
                }
                Console.WriteLine(String.Join(" ", check));
            }
            else
            {
                return;
            }
        }
        static void Add(List<int> list, int index)
        {
            list.Add(index);

            Console.WriteLine(String.Join(" ", list));
        }
        static void Remove(List<int> list, int index)
        {
            list.Remove(index);
            Console.WriteLine(String.Join(" ", list));
        }
        static void RemoveAt(List<int> list, int index)
        {
            list.RemoveAt(index);
            Console.WriteLine(String.Join(" ", list));
        }
        static void Insert(List<int> list, int index, int number)
        {
            list.Insert(number, index);
            Console.WriteLine(String.Join(" ", list));
        }
    }
}