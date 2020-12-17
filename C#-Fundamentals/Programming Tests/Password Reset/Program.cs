using System;
using System.Text;

namespace Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string input = "";
            while ((input = Console.ReadLine()) != "Done")
            {
                string[] tokens = input.Split();
                string action = tokens[0];
                if (action == "TakeOdd")
                {
                    string newPass = "";
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 == 1)
                        {
                            newPass += password[i];
                        }
                    }
                    password = newPass;
                    Console.WriteLine(password);
                }
                else if (action == "Cut")
                {
                    int index = int.Parse(tokens[1]);
                    int length = int.Parse(tokens[2]);
                    string sb = password.Substring(index, length);
                    int indexOfSubstring = password.IndexOf(sb);
                    password = password.Remove(indexOfSubstring, sb.Length);
                    Console.WriteLine(password);
                }
                else if (action == "Substitute")
                {
                    string sb = tokens[1];
                    string substitude = tokens[2];
                    if (password.Contains(sb))
                    {
                        password = password.Replace(sb, substitude);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
