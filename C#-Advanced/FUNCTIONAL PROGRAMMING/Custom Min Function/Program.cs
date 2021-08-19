using System;
using System.Linq;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> check = numbers =>
             {
                 int min = int.MaxValue;
                 foreach (var number in numbers)
                 {
                     if (min > number)
                     {
                         min = number;
                     }
                 }
                 return min;
             };
            Console.WriteLine(check(numbers));
        }
    }

}
