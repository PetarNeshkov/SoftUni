using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] stones = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            Lake lake = new Lake(stones);

            List<int> path = new List<int>();
        
            Console.WriteLine(String.Join(", ",lake));
        }
    }
}
