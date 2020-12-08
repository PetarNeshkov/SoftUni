using System;

namespace Sum_of_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int dIgit = int.Parse(Console.ReadLine());
            int sum = 0;
            while (dIgit>0)
            {
                sum += dIgit % 10;
                dIgit /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
