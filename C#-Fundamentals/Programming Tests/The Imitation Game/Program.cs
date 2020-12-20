using System;

namespace The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input = "";
            while ((input = Console.ReadLine()) != "Decode")
            {
                string[] tokens = input.Split("|");
                string action = tokens[0];
                if (action == "Move")
                {
                    int numberOfLetters = int.Parse(tokens[1]);
                    string Sub = message.Substring(0, numberOfLetters);
                    int index = message.IndexOf(Sub);
                    message = message.Remove(index, Sub.Length);
                    message = message.Insert(message.Length, Sub);
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(tokens[1]);
                    string value = tokens[2];
                    if (index >= 0 && index <= message.Length)
                    {
                        message = message.Insert(index, value);
                    }
                }
                else if (action == "ChangeAll")
                {
                    string Sub = tokens[1];
                    string replacement = tokens[2];
                    if (message.Contains(Sub))
                    {
                        message = message.Replace(Sub, replacement);
                    }
                }
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
