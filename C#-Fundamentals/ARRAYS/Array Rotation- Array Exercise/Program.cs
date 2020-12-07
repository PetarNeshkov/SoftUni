using System;
using System.Linq;

namespace Array_Rotation__Array_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = int.Parse(Console.ReadLine());
            for (int i = 0; i < counter; i++)
            {
                int temp = array[0];
                int[] newArray = new int[array.Length];
                for (int k = 1; k < array.Length; k++)
                {
                    newArray[k - 1] += array[k];
                }
                newArray[array.Length - 1] = temp;
                array = newArray;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
