using System;

namespace Smallest_of_Three_Numbers_Methods_Exercise
{
    class Program
    {
        public static void Main()
        {

            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            BiggestNumber(number1, number2, number3);
        }
        static void BiggestNumber(int number1, int number2, int number3)
        {
            Console.WriteLine(Math.Min(Math.Min(number1, number2), number3));
        }
    }
}

