using System;
using System.Linq;

namespace _08._Condense_Array_to_Number_Lab_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int WagonsCount = int.Parse(Console.ReadLine());
            int[] PeopleInWagons = new int[WagonsCount];
            int sum = 0;

            for (int i = 0; i < WagonsCount; i++)
            {
                int CurrentPeopleInWagon = int.Parse(Console.ReadLine());
                PeopleInWagons[i] += CurrentPeopleInWagon;
                sum += CurrentPeopleInWagon;
            }
            Console.WriteLine(String.Join(" ",PeopleInWagons));
            Console.WriteLine(sum);
        }
    }
}
