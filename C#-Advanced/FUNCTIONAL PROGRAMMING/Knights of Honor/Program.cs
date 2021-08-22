using System;
using System.Linq;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            names = names.Select(x => $"Sir {x}").ToArray();
            Action<string[]> print = x => Console.WriteLine($"{String.Join(Environment.NewLine, names)}");
            print(names);
        }
    }
}
