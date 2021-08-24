using System;
using System.Collections.Generic;
using System.Linq;

namespace Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            string input = "";
            List<string> filters = new List<string>();
            while ((input=Console.ReadLine())!="Print")
            {
                string[] split = input.Split(";");
                string command = split[0];
                string filter = split[1];
                string letter = split[2];
     
                if (command=="Add filter")
                {
                    filters.Add($"{filter}:{letter}");
                }
                else if (command=="Remove filter")
                {
                    filters.Remove($"{filter}:{letter}");
                }
            
            }
            foreach (var item in filters)
            {
                string[] tokens = item.Split(":");
                string filter = tokens[0];
                string letter = tokens[1];
                switch (filter)
                {
                    case "Starts with":
                        names = names.Where(x => !x.StartsWith(letter)).ToList();
                        break;
                    case "Ends with":
                        names = names.Where(x => !x.EndsWith(letter)).ToList();
                        break;
                    case "Length":
                        int length = int.Parse(letter);
                        names = names.Where(x => x.Length != length).ToList();
                        break;
                    case "Contains":
                        names = names.Where(x => !x.Contains(letter)).ToList();
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(" ",names));
        }
    }
}
