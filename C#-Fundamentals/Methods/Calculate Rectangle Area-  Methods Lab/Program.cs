using System;

namespace Calculate_Rectangle_Area___Methods_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine(Rectangle(width,height));
        }
        static int Rectangle(int width,int height)
        {
            return width * height;
        }
    }
}
