using System;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder combinedChars = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                combinedChars.Append(symbol);
            }
            Console.WriteLine(combinedChars);
        }
    }
}