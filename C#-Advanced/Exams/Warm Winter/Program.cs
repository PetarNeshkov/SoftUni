using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class StartUp
    {
        static void Main()
        {
            int[] hatArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] scarfArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> sets = new List<int>();
            Stack<int> hats = new Stack<int>(hatArgs);
            Queue<int> scarfs = new Queue<int>(scarfArgs);

            while (hats.Any() && scarfs.Any())
            {
                int hat = hats.Peek();
                int scarf = scarfs.Peek();

                int sum = hat + scarf;

                if (hat > scarf)
                {
                    hats.Pop();
                    scarfs.Dequeue();
                    sets.Add(sum);
                }
                else if (hat < scarf)
                {
                    hats.Pop();
                }
                else
                {
                    scarfs.Dequeue();
                    hats.Push(hats.Pop() + 1);
                }
            }

            var mostExpensiveSet = sets.OrderByDescending(x => x).FirstOrDefault();
            Console.WriteLine($"The most expensive set is: {mostExpensiveSet}");
            Console.WriteLine($"{String.Join(" ", sets)}");
        }
    }
}