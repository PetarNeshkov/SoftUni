using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < counter; i++)
            {
                int LitersWater = int.Parse(Console.ReadLine());
                sum += LitersWater;
                if (sum>255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= LitersWater;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
