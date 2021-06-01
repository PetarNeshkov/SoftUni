using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            int totalFuel = 0;
            for (int i = 0; i < counter; i++)
            {
                string input = Console.ReadLine();
                input+=$" {i}";
                queue.Enqueue(input);
            }
            for (int i = 0; i < counter; i++)
            {
                string currentInfo = queue.Dequeue();
                var info = currentInfo.Split().Select(int.Parse).ToArray();

                var fuel = info[0];
                var distance = info[1];
                totalFuel += fuel;
                if (totalFuel>=distance)
                {
                    totalFuel -= distance;
                }
                else
                {
                    totalFuel = 0;
                    i=-1;
                }
                queue.Enqueue(currentInfo);
            }
            var firstElements = queue.Dequeue().Split().ToArray();
            Console.WriteLine(firstElements[2]);
        }
    }
}
