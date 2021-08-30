using System;
using System.Linq;

namespace Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).OrderBy(x => x)
                .Where(x=>x%2==0).ToArray();
            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
