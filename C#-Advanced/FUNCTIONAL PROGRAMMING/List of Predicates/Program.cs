using System;
using System.Collections.Generic;
using System.Linq;

namespace List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            var dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var numbers = new List<int>();

            for (int i = 1; i <= range; i++)
            {
                numbers.Add(i);
            }

            List<int> newList = new List<int>();
            for (int i = 1; i <= numbers.Count; i++)
            {
                if(check(dividers, i))
                {
                    newList.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", newList));
        }
        static bool check(int[] array, int currNumber)
        {
            foreach (var number in array)
            {
                if (currNumber%number!=0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
