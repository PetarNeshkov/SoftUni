using System;
using System.Collections.Generic;

namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> dc = new SortedDictionary<char, int>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                if (!dc.ContainsKey(currChar))
                {
                    dc.Add(currChar,0);
                }
                dc[currChar]++;
            }
            foreach (var item in dc)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
