using System;

namespace Multiply_Evens_by_Odds___Methods_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            GetSumOfOddDigits(number);
            GetSumOfEvenDigits(number);
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }
        static int GetSumOfEvenDigits(int number)
        {
            string stringNumber = number.ToString();
            int sum = 0;
            for (int i = 0; i < stringNumber.Length; i++)
            {
                int currentDigit = int.Parse(stringNumber[i].ToString());
                if (currentDigit % 2 == 0)
                {
                    sum += currentDigit;
                }
            }
            return sum;
        }
        static int GetSumOfOddDigits(int number)
        {
            string stringNumber = number.ToString();
            int sum = 0;
            for (int i = 0; i < stringNumber.Length; i++)
            {
                int currentDigit = int.Parse(stringNumber[i].ToString());
                if (currentDigit % 2 != 0)
                {
                    sum += currentDigit;
                }
            }
            return sum;
        }
        static int GetMultipleOfEvenAndOdds(int number)
        {
            int sum = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
            return sum;
        }
    }
}

