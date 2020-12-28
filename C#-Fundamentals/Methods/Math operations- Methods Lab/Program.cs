using System;

namespace Math_operations__Methods_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            char Operator = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(check(firstNumber, secondNumber, Operator));
        }
        static int check(int firstNumber, int secondNumber, char Operator)
        {
            int result = 0;
            if (Operator == '+')
            {
                result = firstNumber + secondNumber;
            }
            else if (Operator == '-')
            {
                result = firstNumber - secondNumber;
            }
            else if (Operator == '*')
            {
                result = firstNumber * secondNumber;
            }
            else if (Operator == '/')
            {
                result = firstNumber / secondNumber;
            }
            return result;
        }
    }
}
