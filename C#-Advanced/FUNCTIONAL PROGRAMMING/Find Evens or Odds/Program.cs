using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int start = numbers[0];
            int end = numbers[1];

            List<int> List = new List<int>();
            for (int i = start; i <= end; i++)
            {
                List.Add(i);
            }

            Predicate<int> predicate = n => true;
            string action = Console.ReadLine();
            if (action=="odd")
            {
                predicate = x => x % 2 != 0;
            }
            else if (action=="even")
            {
                predicate = x => x % 2 == 0;
            }
            List = check(List, predicate);
            Console.WriteLine(String.Join(" ",List));
        }
        static List<int>check(List<int> list,Predicate<int> predicate)
        {
            List<int> newList = new List<int>();
            foreach (var digit in list)
            {
                if (predicate(digit))
                {
                    newList.Add(digit);
                }
            }
            return newList;
        }
    }
}
