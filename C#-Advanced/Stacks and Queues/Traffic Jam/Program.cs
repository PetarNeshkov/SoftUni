using System;
using System.Collections.Generic;

namespace Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            string input = "";
            int passedCars = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    if (count > queue.Count)
                    {
                        count = queue.Count;
                    }
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            passedCars++;
                        }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }
            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
