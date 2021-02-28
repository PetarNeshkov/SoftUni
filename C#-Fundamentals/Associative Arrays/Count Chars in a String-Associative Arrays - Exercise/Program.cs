using System;
using System.Collections.Generic;

namespace Count_Chars_in_a_String_Associative_Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> counter = new Dictionary<char, int>();
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                if (!counter.ContainsKey(text[i]))
                {
                    counter.Add(text[i], 1);
                }
                else
                {
                    counter[text[i]]++;
                }
            }
            foreach (var item in counter)
            {
                if (item.Key != ' ')
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }
    }
}
