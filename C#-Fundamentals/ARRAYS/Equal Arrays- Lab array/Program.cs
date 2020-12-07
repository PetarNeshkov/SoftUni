using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Equal_Arrays__Lab_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                while (array.Length > 1)
                {
                    int[] temp = new int[array.Length - 1];
                    for (int j = 0; j < array.Length - 1; j++)
                    {
                        temp[j] = array[j] + array[j + 1];
                    }
                    array = temp;
                }
            }
            Console.WriteLine(array[0]);
        }
    }
}
