using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int mainFoodQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(orders);
            Console.WriteLine(orders.Max());
            while (queue.Count>0)
            {
                int food = queue.Peek();
                if (mainFoodQuantity>=food)
                {
                    mainFoodQuantity -= food;
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (queue.Count>0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ",queue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
