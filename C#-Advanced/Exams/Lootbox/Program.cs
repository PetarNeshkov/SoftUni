using System;
using System.Collections.Generic;
using System.Linq;

namespace Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondBox = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> firstBoxQueue = new Queue<int>(firstBox);
            Stack<int> secondBoxStack = new Stack<int>(secondBox);

            List<int> claimedSum = new List<int>();

            while (firstBoxQueue.Any() && secondBoxStack.Any())
            {
                int currFirstBox = firstBoxQueue.Peek();
                int currSecondBox = secondBoxStack.Peek();

                int currSum = currFirstBox + currSecondBox;
                if (currSum % 2 == 0)
                {
                    claimedSum.Add(currSum);
                    firstBoxQueue.Dequeue();
                    secondBoxStack.Pop();
                }
                else
                {
                    secondBoxStack.Pop();
                    firstBoxQueue.Enqueue(currSecondBox);
                }
            }
            if (firstBoxQueue.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }
            int TotalSum = claimedSum.Sum();
            if (TotalSum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {TotalSum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {TotalSum}");
            }
        }
    }
}
