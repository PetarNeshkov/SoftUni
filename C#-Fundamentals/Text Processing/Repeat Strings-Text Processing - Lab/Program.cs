using System;
using System.Text;

namespace Repeat_Strings_Text_Processing___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string []input = Console.ReadLine().Split();
            StringBuilder concant = new StringBuilder();
            foreach (var letter in input)
            {
                for (int i = 0; i < letter.Length; i++)
                {
                    concant.Append(letter);
                }
            }
            Console.WriteLine(concant);
        }
    }
}
