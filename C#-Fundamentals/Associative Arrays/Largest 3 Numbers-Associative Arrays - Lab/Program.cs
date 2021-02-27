using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_3_Numbers_Associative_Arrays___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sorted = numbers.OrderByDescending(x => x).Take(3).ToArray();
            Console.Write(String.Join(" ",sorted));
        }
    }
}
