using System;

namespace Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Action<string[]> print = x => Console.WriteLine(String.Join(Environment.NewLine,x));
            print(names);
        }
    }
}
