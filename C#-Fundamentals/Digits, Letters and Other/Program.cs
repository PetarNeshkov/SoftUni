using System;
using System.Text;

namespace Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder letters = new StringBuilder();
            StringBuilder digits = new StringBuilder();
            StringBuilder others = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    letters.Append(input[i]);
                }
                else if (char.IsDigit(input[i]))
                {
                    digits.Append(input[i]);
                }
                else
                {
                    others.Append(input[i]);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
