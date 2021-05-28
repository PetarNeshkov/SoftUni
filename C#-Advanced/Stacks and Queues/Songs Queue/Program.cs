using System;
using System.Collections.Generic;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            
            Queue<string> queue = new Queue<string>(songs);
            while (queue.Count>0)
            {
                string input = Console.ReadLine();
                if (input.Contains("Play"))
                {
                    queue.Dequeue();
                }
                else if (input.Contains("Add"))
                {
                    string[]split=input.Split("Add ",StringSplitOptions.RemoveEmptyEntries);
                    if (queue.Contains(split[0]))
                    {
                        Console.WriteLine($"{split[0]} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(split[0]);
                    }
                }
                else if (input.Contains("Show"))
                {
                    Console.WriteLine(String.Join(", ",queue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
