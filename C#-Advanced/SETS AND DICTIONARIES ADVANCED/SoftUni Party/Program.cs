using System;
using System.Collections.Generic;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            string input = "";
            while ((input=Console.ReadLine())!="PARTY")
            {
                set.Add(input);
            }
            while ((input = Console.ReadLine()) != "END")
            {
                if (set.Contains(input))
                {
                    set.Remove(input);
                }
            }
            Console.WriteLine(set.Count);
            foreach (var item in set)
            {
                char[] ch = item.ToCharArray();
                if (char.IsDigit(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }
            foreach (var item in set)
            {
                char[] ch = item.ToCharArray();
                if (char.IsLetter(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
