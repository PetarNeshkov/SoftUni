using System;

namespace Kamino_Factory_Array_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequenceOfArrays = int.Parse(Console.ReadLine());
            string input = string.Empty;
            int counter = 0;
            int bestCount = 0;
            int bestBeginIndex = 0;
            int bestSum = 0;
            int BestCounter = 0;
            string bestSequence = "";
            while ((input = Console.ReadLine()) != "Clone them!")
            {
                string sequence = input.Replace("!", "");
                string[] array = sequence.Split("0", StringSplitOptions.RemoveEmptyEntries);

                int count = 0;
                int sum = 0;
                string BestSubSequence = "";
                counter++;

                foreach (string dnaPart in array)
                {
                    if (dnaPart.Length > count)
                    {
                        count = dnaPart.Length;
                        BestSubSequence = dnaPart;
                    }
                    sum += dnaPart.Length;
                }

                int beginIndex = sequence.IndexOf(BestSubSequence);

                if (count > bestCount ||
                    count == bestCount && beginIndex < bestBeginIndex ||
                    (count == bestCount && beginIndex == bestBeginIndex &&
                    sum > bestSum)||counter==1)
                {
                    bestCount = count;
                    bestSequence = sequence;
                    bestBeginIndex = beginIndex;
                    bestSum = sum;
                    BestCounter = counter;
                }
            }
            char[] result = bestSequence.ToCharArray();
            Console.WriteLine($"Best DNA sample {BestCounter} with sum: {bestSum}.");
            Console.WriteLine($"{String.Join(" ",result)}");
        }
    }
}
