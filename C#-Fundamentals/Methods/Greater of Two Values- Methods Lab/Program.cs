using System;

namespace Greater_of_Two_Values__Methods_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            if (value == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(checkInt(firstNumber,secondNumber));
            }
            else if (value == "char")
            {
                char firstDigit = char.Parse(Console.ReadLine());
                char secondDigit = char.Parse(Console.ReadLine());
                Console.WriteLine(charCheck(firstDigit,secondDigit));
            }
            else
            {
                string firstLetter = Console.ReadLine();
                string secondLetter = Console.ReadLine();
                Console.WriteLine(stringCheck(firstLetter, secondLetter));
            }
        }
        static int checkInt(int firstNumber, int secondNumber)
        {
            int compare = firstNumber.CompareTo(secondNumber);
            if (compare>0)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
        static char charCheck(char firstDigit, char secondDigit)
        {
            int compare = firstDigit.CompareTo(secondDigit);
            if (compare > 0)
            {
                return firstDigit;
            }
            else
            {
                return secondDigit;
            }
        }
        static string stringCheck(string firstLetter, string secondLetter)
        {
            int compare = firstLetter.CompareTo(secondLetter);
            if (compare > 0)
            {
                return firstLetter;
            }
            else
            {
                return secondLetter;
            }
        }
    }
}
