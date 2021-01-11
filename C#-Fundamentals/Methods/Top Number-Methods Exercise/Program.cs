using System;

namespace Top_Number_Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            TopNumber(number);
        }
        static void TopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                string currentNumber = i.ToString();
                int sumOfNumbers = 0;
                int OddDigits = 0;
                for (int l = 0; l < currentNumber.Length; l++)
                {
                    int ParseNumber = currentNumber[l];
                    sumOfNumbers += ParseNumber;
                    if (ParseNumber % 2 != 0)
                    {
                        OddDigits++;
                    }
                }
                if (OddDigits > 0 && (sumOfNumbers % 8 == 0 || sumOfNumbers % 16 == 0
                    || sumOfNumbers % 88 == 0))
                {
                    Console.WriteLine(currentNumber);
                }
            }
        }
    }
}
