using System;
using System.Linq;

namespace Rouding_Numbers__Lab_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
