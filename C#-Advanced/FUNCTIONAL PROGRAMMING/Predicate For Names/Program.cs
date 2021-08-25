using System;
using System.Linq;

namespace Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght =int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            names = names.Where(x => x.Length <= lenght).ToArray();
            Console.WriteLine($"{String.Join(Environment.NewLine,names)}");
        }
    }
}
