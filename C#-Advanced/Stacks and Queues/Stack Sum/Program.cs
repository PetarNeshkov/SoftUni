using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = "";
            Stack<int> stack = new Stack<int>(numbers);
            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] spllited = input.Split();
                string action = spllited[0];
                if (action == "add")
                {
                    stack.Push(int.Parse(spllited[1]));
                    stack.Push(int.Parse(spllited[2]));
                }
                else if (action == "remove")
                {
                    int count = int.Parse(spllited[1]);
                    if (count <= stack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
