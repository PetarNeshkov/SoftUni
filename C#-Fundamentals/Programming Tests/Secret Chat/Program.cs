using System;
using System.Linq;

namespace Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input = string.Empty;
            while ((input=Console.ReadLine())!="Reveal")
            {
                string[] tokens = input.Split(":|:");
                string action = tokens[0];
                if (action=="InsertSpace")
                {
                    int index = int.Parse(tokens[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (action=="Reverse")
                {
                    string sub = tokens[1];
                    if (message.Contains(sub))
                    {
                        char[] reversed = sub.Reverse().ToArray();
                        string newSub = new string(reversed);
                        int index = message.IndexOf(sub);
                        message = message.Remove(index, sub.Length);
                        message = message.Insert(message.Length, newSub);
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (action=="ChangeAll")
                {
                    string sub = tokens[1];
                    string replacement = tokens[2];
                    message = message.Replace(sub,replacement);
                    Console.WriteLine(message);
                }
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
