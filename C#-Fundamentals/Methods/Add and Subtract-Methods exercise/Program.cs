using System;

namespace Add_and_Subtract_Methods_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber = int.Parse(Console.ReadLine());
            int SecondNumber = int.Parse(Console.ReadLine());
            int ThirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(AddandSubtract(FirstNumber, SecondNumber, ThirdNumber));
        }
        static int AddandSubtract(int FirstNumber,int SecondNumber,int ThirdNumber)
        {
            int sum = FirstNumber + SecondNumber;
            sum -= ThirdNumber;
            return sum;
        }
    }
}
