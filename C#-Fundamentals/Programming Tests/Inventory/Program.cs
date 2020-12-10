using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();
            string input = " ";
            while ((input = Console.ReadLine()) != "Craft!")
            {
                string[] commands = input.Split(new string[] { " - ", ":" }, StringSplitOptions.RemoveEmptyEntries);
                string action = commands[0];
                if (action == "Collect")
                {
                    string item = commands[1];
                    if (!items.Contains(item))
                    {
                        items.Add(item);
                    }
                }
                else if (action == "Drop")
                {
                    string item = commands[1];
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                    }
                }
                else if (action == "Combine Items")
                {
                    string oldItem = commands[1];
                    string newItem = commands[2];
                    if (items.Contains(oldItem))
                    {
                        int index = items.IndexOf(oldItem);
                        items.Insert(index + 1, newItem);
                    }
                }
                else if (action == "Renew")
                {
                    string item = commands[1];
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                        items.Insert(items.Count, item);
                    }
                }
            }
            Console.WriteLine(String.Join(", ", items));
        }
    }
}