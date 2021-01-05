using System;

namespace Password_Validator_Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            check(password);
        }
        static void check(string word)
        {
            bool isTrue = false;
            if (!(word.Length>=6&&word.Length<=10))
            {
                Console.WriteLine($"Password must be between 6 and 10 characters");
                isTrue = true;
            }
            int digits = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    digits++;
                }
                if (!(char.IsLetterOrDigit(word[i])))
                {
                    isTrue = true;
                    Console.WriteLine($"Password must consist only of letters and digits");
                    break;
                }
            }
            if (digits<2)
            {
                Console.WriteLine($"Password must have at least 2 digits");
                isTrue = true;
            }
            if (isTrue==false)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}