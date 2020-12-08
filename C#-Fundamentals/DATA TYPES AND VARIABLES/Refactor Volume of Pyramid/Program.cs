using System;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, widh, height = 0;
            double volume = 0;
            Console.Write("Length:");
            length = double.Parse(Console.ReadLine());
            Console.Write(" Width: ");
            widh = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());
            volume = (length * widh * height) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}