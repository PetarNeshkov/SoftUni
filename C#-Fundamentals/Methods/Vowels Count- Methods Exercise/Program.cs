using System;
using System.Linq;

namespace Vowels_Count__Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            word=word.ToLower();
            Vowels(word);
        }
        static void Vowels(string word)
        {
            char[] Vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (Vowels.Contains(word[i]))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
