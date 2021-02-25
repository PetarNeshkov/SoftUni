using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Occurrences_Associative_Arrays___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] occurences = Console.ReadLine().Split();
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (var item in occurences)
            {
                if (!counts.ContainsKey(item.ToLower()))
                {
                    counts.Add(item.ToLower(), 1);
                }
                else
                {
                    counts[item.ToLower()]++;
                }
            }
            foreach (var item in counts)
            {
                if (item.Value%2==1)
                {
                    Console.Write(item.Key+" ");
                }
            }
        }
    }
}
