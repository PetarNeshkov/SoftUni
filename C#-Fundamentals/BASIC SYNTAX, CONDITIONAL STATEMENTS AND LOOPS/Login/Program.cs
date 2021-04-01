using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string reversedPassword = "";
            for (int i = username.Length - 1; i >= 0; i--)
            {
                reversedPassword += username[i];
            }
            string input = Console.ReadLine();
            int incorrectPasswordCount = 0;
            while (input != reversedPassword)
            {
                incorrectPasswordCount++;
                if (incorrectPasswordCount == 4)
                {
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
            }
            if (incorrectPasswordCount != 4)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            else
            {
                Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}