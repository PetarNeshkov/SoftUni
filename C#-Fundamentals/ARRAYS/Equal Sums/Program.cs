using System;
using System.Linq;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isFound = false;
            for (int curr = 0; curr < array.Length; curr++)
            {
                int rightSum = 0;
                for (int k = curr + 1; k < array.Length; k++)
                {
                    rightSum += array[k];
                }
                int leftSum = 0;
                for (int i = curr-1; i >=0 ; i--)
                {
                    leftSum += array[i];
                }
                if (leftSum==rightSum)
                {
                    Console.WriteLine(curr);
                    isFound = true;
                    break;
                }
            }
            if (isFound==false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
