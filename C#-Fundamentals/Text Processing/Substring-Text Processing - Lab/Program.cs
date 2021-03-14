using System;

namespace Substring_Text_Processing___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine().ToLower();
            string secondString = Console.ReadLine();
            while (secondString.Contains(firstString))
            {
                int index = secondString.IndexOf(firstString);
                secondString = secondString.Remove(index, firstString.Length);
            }
            Console.WriteLine(secondString);
        }
    }
}
