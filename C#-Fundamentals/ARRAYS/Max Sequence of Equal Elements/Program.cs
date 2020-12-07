using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < Array.Length; i++)
            {
                for (int k = i + 1; k < Array.Length; k++)
                {
                    if (Array[i] + Array[k] == magicNumber)
                    {
                        Console.WriteLine($"{Array[i]} {Array[k]}");
                        break;
                    }
                }
            }
        }
    }
}
