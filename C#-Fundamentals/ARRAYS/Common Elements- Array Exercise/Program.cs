using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();
            string[] array1 = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array1[i] == array[j])
                    {
                        Console.Write(array1[i] + " ");
                    }
                }
            }
        }
    }
}
