using System;

namespace Palindrome_Integers__Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            PalindromeIntegers(command);
        }
        static void PalindromeIntegers(string command)
        {
            while (command!="END")
            {
                bool isPalindrome = true;
                for (int i = 0; i < command.Length/2; i++)
                {
                    if (command[i]!=command[command.Length-1-i])
                    {
                        isPalindrome = false;
                        Console.WriteLine("false");
                        break;
                    }
                }
                if (isPalindrome)
                {
                    Console.WriteLine("true");
                }
                command = Console.ReadLine();
            }
        }
    }
}
