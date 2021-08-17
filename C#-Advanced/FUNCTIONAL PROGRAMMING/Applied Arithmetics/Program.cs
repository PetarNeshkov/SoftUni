using System;
using System.Linq;

namespace Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int, int> add = x => x + 1;
            Func<int, int> multiply = x => x * 2;
            Func<int, int> subtract = x => x - 1;
            while ((input=Console.ReadLine())!="end")
            {
                switch (input)
                {
                    case "add":
                        numbers = numbers.Select(add).ToArray();
                            break;
                    case "multiply":
                        numbers = numbers.Select(multiply).ToArray();
                        break;
                    case "subtract":
                        numbers = numbers.Select(subtract).ToArray();
                        break;
                    case "print":
                        Console.WriteLine(String.Join(" ",numbers));
                        break;
                    default:
                        break;
                }
            }
        }
       
    }
}
