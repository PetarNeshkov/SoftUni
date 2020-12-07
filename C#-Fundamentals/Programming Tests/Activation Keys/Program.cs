using System;

namespace Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string input = "";
            while ((input=Console.ReadLine())!="Generate")
            {
                string[] commands = input.Split(">>>",StringSplitOptions.RemoveEmptyEntries);
                string action = commands[0];
                if (action=="Contains")
                {
                    string sub = commands[1];
                    if (key.Contains(sub))
                    {
                     Console.WriteLine($"{key} contains {sub}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (action=="Flip")
                {
                    string secondAct = commands[1];
                    if (secondAct=="Upper")
                    {
                        int startIndex = int.Parse(commands[2]);
                        int endIndex = int.Parse(commands[3]);
                        string sub = key.Substring(startIndex, endIndex - startIndex);
                        key = key.Replace(sub,sub.ToUpper());
                        Console.WriteLine(key);
                    }
                    else if (secondAct=="Lower")
                    {
                        int startIndex = int.Parse(commands[2]);
                        int endIndex = int.Parse(commands[3]);
                        string sub = key.Substring(startIndex, endIndex - startIndex);
                        key = key.Replace(sub, sub.ToLower());
                        Console.WriteLine(key);
                    }
                }
                else if (action=="Slice")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    string sub = key.Substring(startIndex, endIndex - startIndex);
                    key = key.Replace(sub,"");
                    Console.WriteLine(key);
                }
            }
            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
