using System;

namespace Factorial_Division_Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            FactorialDivision(firstNumber, secondNumber);
        }
        static void FactorialDivision(int firstNumber, int secondNumber)
        {
            decimal Firstfactorial = 1;
            decimal Secondfactorial = 1;
            for (int i = 1; i <= firstNumber; i++)
            {
                Firstfactorial *= i;
            }
            for (int i = 1; i <=secondNumber; i++)
            {
                Secondfactorial *= i;
            }
            Firstfactorial /= Secondfactorial;
            Console.WriteLine($"{Firstfactorial:F2}");
        }
    }
}
