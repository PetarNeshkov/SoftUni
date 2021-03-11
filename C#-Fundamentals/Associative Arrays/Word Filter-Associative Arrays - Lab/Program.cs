using System;
using System.Collections.Generic;

namespace Word_Filter_Associative_Arrays___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = Console.ReadLine().Split();
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i].Length%2==0)
                {
                    Console.WriteLine(fruits[i]);
                }
            }
        }
    }
}
