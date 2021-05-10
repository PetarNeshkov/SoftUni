using System;
using System.Linq;

namespace Top_Interegrs_Arrays_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
            bool isBigger = true;
                int currentInt = array[i];
                for (int k = i+1; k < array.Length; k++)
                {
                    if (currentInt <= array[k])
                    {
                        isBigger = false;
                        break;
                    }
                }
                if (isBigger==true)
                {
                    Console.Write(currentInt+ " ");
                }
            }
        }
    }
}
