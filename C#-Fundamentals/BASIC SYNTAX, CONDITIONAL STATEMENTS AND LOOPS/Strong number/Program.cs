using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int NumberToInt = int.Parse(number);
            int finalSum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int currentNum = int.Parse(number[i].ToString());
                int factorial = 1;
                for (int k = 1; k <= currentNum; k++)
                {
                    factorial *= k;

                }
                if (currentNum != 0)
                {
                    finalSum += factorial;
                }
                else finalSum += 1;
            }
            if (finalSum == NumberToInt)
            {
                Console.WriteLine("yes");
            }
            else Console.WriteLine("no");
        }
    }
}
