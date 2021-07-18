using System;
using System.Collections.Generic;

namespace Unique_Usernames
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
                hash.Add(name);
            }
            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
        }
    }
}
