using System;
using System.Collections.Generic;

namespace Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            HashSet<string> hash = new HashSet<string>();
            for (int i = 0; i < counter; i++)
            {
                string name = Console.ReadLine();
                if (!hash.Contains(name))
                {
                    hash.Add(name);
                }
            }
            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
        }
    }
}
