using System;
using System.Collections.Generic;
using System.Linq;

namespace Flower_Wreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lilies = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] roses = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> liliesStack = new Stack<int>(lilies);
            Queue<int> rosesQueue= new Queue<int>(roses);

            int wreaths = 0;
            int sum = 0;
            while (liliesStack.Any() && rosesQueue.Any())
            {
                int currLilly = liliesStack.Peek();
                int currRose = rosesQueue.Peek();

                if (currLilly + currRose == 15)
                {
                    wreaths++;
                    liliesStack.Pop();
                    rosesQueue.Dequeue();
                }
                else if (currLilly + currRose > 15)
                {
                    currLilly -= 2;
                    liliesStack.Pop();
                    liliesStack.Push(currLilly);
                }
                else
                {
                    sum += currLilly + currRose;
                    liliesStack.Pop();
                    rosesQueue.Dequeue();
                }
            }
            sum /= 15;
            wreaths += sum;
            if (wreaths<5)
            {
                Console.WriteLine($"You didn't make it, you need {5-wreaths} wreaths more!");
            }
            else
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
        }
    }
}
