using System;
using System.Linq;

namespace Even_and_Odd_Subtraction__Lab_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfOdd = 0;
            int sumOfEven = 0;
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] %2==0)
                {
                    sumOfEven += array[i];
                }
                else
                {
                    sumOfOdd += array[i];
                }
            }
            Console.WriteLine($"{sumOfEven-sumOfOdd}");
        }
    }
}
