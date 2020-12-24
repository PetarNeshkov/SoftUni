using System;
using System.Text;

namespace Repeat_String__Methods_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());
            RepeatString(text,counter);
        }
        static void RepeatString(string text,int counter)
        {
            StringBuilder finalText = new StringBuilder();
            for (int i = 0; i < counter; i++)
            {
                finalText.Append(text);
            }
            Console.WriteLine(finalText);
        }
        
    }
}
