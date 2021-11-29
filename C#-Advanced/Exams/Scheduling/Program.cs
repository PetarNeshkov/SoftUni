using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tasks = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[] threads = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int taskToKill = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(tasks);
            Queue<int> queue = new Queue<int>(threads);
            while (stack.Any() && queue.Any())
            {
                int taskValue = stack.Peek();
                int threadValue = queue.Peek();

                if (taskToKill == taskValue)
                {
                    Console.WriteLine($"Thread with value {threadValue} killed task {taskToKill}");
                    Console.WriteLine(String.Join(" ", queue));
                    return;
                }
                if (threadValue >= taskValue)
                {
                    stack.Pop();
                    queue.Dequeue();
                }
                else
                {
                    queue.Dequeue();
                }

            }
        }
    }
}
