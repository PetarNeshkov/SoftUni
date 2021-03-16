using System;
using System.Linq;

namespace Text_Filter_Text_Processing___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach (var word in words)
            {
                string replace = new string('*', word.Length);
                text = text.Replace(word, replace);
            }
            Console.WriteLine(text);
        }
    }
}
