using System;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            if (char.IsUpper(symbol))
            {
                Console.WriteLine("upper-case");
            }
            else Console.WriteLine("lower-case");
        }
    }
}
