using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dc = new Dictionary<string, List<string>>();
            int counter = int.Parse(Console.ReadLine());
            for (int i = 0; i < counter; i++)
            {
                string[] information = Console.ReadLine().Split("|");
                string piece = information[0];
                string composer = information[1];
                string key = information[2];
                dc.Add(piece, new List<string>() { composer, key });
            }
            string input = "";
            while ((input=Console.ReadLine())!="Stop")
            {
                string[] information = input.Split("|");
                string action = information[0];
                if (action=="Add")
                {
                    string piece = information[1];
                    string composer = information[2];
                    string key = information[3];
                    if (dc.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        dc.Add(piece, new List<string>() { composer, key });
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                }
                else if (action=="Remove")
                {
                    string piece = information[1];
                    if (dc.ContainsKey(piece))
                    {
                        dc.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (action=="ChangeKey")
                {
                    string piece = information[1];
                    string newKey = information[2];
                    if (dc.ContainsKey(piece))
                    {
                        dc[piece].Remove(dc[piece].Last());
                        dc[piece].Add(newKey);
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
            }
            foreach (var item in dc.OrderBy(name=>name.Key)
                .ThenBy(composer=>composer.Value[0]))
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value[0]}, Key: {item.Value[1]}");
            }
        }
    }
}
