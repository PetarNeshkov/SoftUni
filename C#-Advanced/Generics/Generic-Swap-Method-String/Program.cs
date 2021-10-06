using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic_Swap_Method_String
{
   public class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                box.Add(input);
            }
            int[] split = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstIndex = split[0];
            int secondIndex = split[1];
            box.Swap(firstIndex, secondIndex);
            Console.WriteLine(box);
        }
    }
}
