using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(clothes);
            int rackCapacity = int.Parse(Console.ReadLine());
            int racksCount = 0;
            int sum = 0;
            while (stack.Count>0)
            {
                int currNum = stack.Peek();
                sum += currNum;
                if (sum<rackCapacity)
                {
                    stack.Pop();
                }
                else if (sum==rackCapacity)
                {
                    sum = 0;
                    racksCount++;
                    stack.Pop();
                }
                else
                {
                    sum = 0;
                    racksCount++;
                }
            }
            if (sum>0)
            {
                racksCount++;
            }
            Console.WriteLine(racksCount);
        }
    }
}
