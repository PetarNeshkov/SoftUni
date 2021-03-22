using System;
using System.Text;

namespace Replace_Repeating_Chars_Text_Processing___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length - 1; i++)
            {
                char firstLetter = input[i];
                char secondLetter = input[i + 1];
                if (firstLetter != secondLetter)
                {
                    sb.Append(firstLetter);
                }
            }
            sb.Append(input[input.Length - 1]);
            Console.WriteLine(sb);
        }
    }
}
