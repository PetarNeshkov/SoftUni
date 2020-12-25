using System;

namespace Math_Power__Methods_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(MathPower(number, power));
        }
        static double MathPower(double number, double power)
        {
            double sum = 1;
            for (int i = 0; i < power; i++)
            {
                sum *= number;
            }
            return sum;
        }
    }
}
