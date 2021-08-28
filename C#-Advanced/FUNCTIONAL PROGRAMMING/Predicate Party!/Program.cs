using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            string input = "";
            while ((input=Console.ReadLine())!="Party!")
            {
                string[] array = input.Split();
                string command = array[0];
                string secondCommand = array[1];
                string letter = array[2];
                if (command=="Remove")
                {
                    Predicate<string>predicate= checkPredicate(secondCommand, letter);
                    names.RemoveAll(predicate);
                }
                else if (command=="Double")
                {
                    Func<string, bool> check = checks(secondCommand, letter);
                   var namesToWorkWith = names.Where(check).ToList();
                    names.InsertRange(0, namesToWorkWith);
                }
            }
            if (names.Any())
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
        static Func<string,bool> checks(string command,string letter)
        {
            switch (command)
            {
                case "StartsWith":
                    return x => x.StartsWith(letter);
                case "EndsWith":
                    return x => x.EndsWith(letter);
                case "Length":
                    int lenght =int.Parse(letter);
                    return x => x.Length==lenght;
                default:
                    return null;
            }
        }
        static Predicate<string> checkPredicate(string command,string letter)
        {
            switch (command)
            {
                case "StartsWith":
                    return x => x.StartsWith(letter);
                case "EndsWith":
                    return x => x.EndsWith(letter);
                case "Length":
                    int lenght = int.Parse(letter);
                    return x => x.Length == lenght;
                default:
                    return null;
            }
        }
    }
}
