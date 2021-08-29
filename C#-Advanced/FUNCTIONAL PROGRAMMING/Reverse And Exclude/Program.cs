using System;
using System.Linq;

namespace Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number =int.Parse(Console.ReadLine());
            numbers = numbers.Where(x => x % number != 0)
                .Reverse()
                .ToArray();
            Console.WriteLine(String.Join(" ",numbers));

        }
    }
}
