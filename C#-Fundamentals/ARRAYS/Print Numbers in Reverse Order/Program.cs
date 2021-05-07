using System;
using System.Linq;

namespace Day_of_Week__Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int[] array = new int[counter];
            for (int i = 0; i < counter; i++)
            {
                int number = int.Parse(Console.ReadLine());
                array[i] += number;
            }
            Array.Reverse(array);
            Console.WriteLine(String.Join(" ",array));
        }
    }
}
