using System;

namespace Character_Multiplier_Text_Processing___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string firstString = input[0];
            string secondString = input[1];
            int sum = 0;
            string bigger = "";
            string shorter = "";
            if (firstString.Length>secondString.Length)
            {
                bigger = firstString;
                shorter = secondString;
            }
            else
            {
                bigger = secondString;
                shorter = firstString;
            }
            for (int i = 0; i < shorter.Length; i++)
            {
                sum += shorter[i]*bigger[i];
            }
            for (int i = shorter.Length; i < bigger.Length; i++)
            {
                sum += bigger[i];
            }
            Console.WriteLine(sum);
        }
    }
}
