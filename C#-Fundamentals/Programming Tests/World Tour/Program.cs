using System;

namespace World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string destinations = Console.ReadLine();
            string input = "";
            while ((input=Console.ReadLine())!="Travel")
            {
                string[] tokens = input.Split(":");
                string action = tokens[0];
                if (action == "Add Stop")
                {
                    int index = int.Parse(tokens[1]);
                    string String = tokens[2];
                    if (index >= 0 && index < destinations.Length)
                    {
                        destinations = destinations.Insert(index, String);
                    }
                        Console.WriteLine(destinations);
                }
                else if (action == "Remove Stop")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    if (startIndex >= 0 && startIndex < destinations.Length
                        && endIndex >= 0 && endIndex <destinations.Length)
                    {
                        destinations = destinations.Remove(startIndex, endIndex - startIndex+1);
                        Console.WriteLine(destinations);
                    }
                }
                else if (action == "Switch")
                {
                    string oldString = tokens[1];
                    string newString = tokens[2];
                    if (destinations.Contains(oldString))
                    {
                        destinations = destinations.Replace(oldString, newString);
                    }
                    Console.WriteLine(destinations);
                }
                
            }
             Console.WriteLine($"Ready for world tour! Planned stops: {destinations}");
        }
    }
}
