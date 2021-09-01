using System;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Console.WriteLine(names.FirstOrDefault(x => x.ToCharArray()
            .Select(y => (int)y)
            .Sum()>=n));
        }
    }
}
