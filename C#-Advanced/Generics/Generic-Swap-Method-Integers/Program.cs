using System;
using System.Linq;

namespace Generic_Swap_Method_Integers
{
  public class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();
            for (int i = 0; i < n; i++)
            {
                int currNumber =int.Parse(Console.ReadLine());
                box.Add(currNumber);
            }
            int[] split = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstNumber = split[0];
            int secondNumber = split[1];
            box.Swap(firstNumber, secondNumber);
            Console.WriteLine(box);
        }
    }
}
