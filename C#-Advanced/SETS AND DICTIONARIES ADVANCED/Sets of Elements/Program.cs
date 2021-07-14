using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] counts = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> firstHesh = new HashSet<int>();
            HashSet<int> secondHesh = new HashSet<int>();
            for (int i = 0; i < counts[0]; i++)
            {
                int input = int.Parse(Console.ReadLine());
                firstHesh.Add(input);
            }
            for (int i = 0; i < counts[1]; i++)
            {
                int input = int.Parse(Console.ReadLine());
                secondHesh.Add(input);
            }
            HashSet<int> combined = firstHesh.Intersect(secondHesh).ToHashSet();
            Console.Write(String.Join(" ",combined));
        }
    }
}
