using System;

namespace Middle_Characters__Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            MiddleCharacters(text);
        }
        static void MiddleCharacters(string text)
        {
            string input = " ";
            if (text.Length%2==0)
            {
                input = text.Substring((text.Length / 2)- 1, 2);
            }
            else
            {
                input = text.Substring(text.Length / 2, 1);
            }
            Console.WriteLine(input);
        }
    }
}
