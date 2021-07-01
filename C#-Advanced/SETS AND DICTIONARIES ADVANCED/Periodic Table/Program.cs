using System;
using System.Collections.Generic;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            SortedSet<string> hash = new SortedSet<string>();
            for (int i = 0; i < counter; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int k = 0; k < input.Length; k++)
                {
                    string curString = input[k];
                    hash.Add(curString);
                }
            }
            Console.WriteLine(String.Join(" ",hash));
        }
    }
}
