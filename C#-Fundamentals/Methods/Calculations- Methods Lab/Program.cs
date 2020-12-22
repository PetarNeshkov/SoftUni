using System;

namespace Calculations__Methods_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(calculations(command, firstNumber, secondNumber));     
        }
        static double calculations(string command,int firstNumber,int secondNumber)
        {
            double sum = 0;
            switch (command)
            {
                case "subtract":
                    sum = firstNumber - secondNumber;
                    return sum;
                case "add":
                    sum = firstNumber + secondNumber;
                    return sum;
                case "multiply":
                    sum = firstNumber * secondNumber;
                    return sum;
                case "divide":
                    sum = firstNumber / secondNumber;
                    return sum;
            }
            return sum;
        }

    }
}
