using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine().Split("!").ToList();
            string input = "";
            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] commands = input.Split();
                string action = commands[0];
                if (action == "Urgent")
                {
                    string item = commands[1];
                    if (!products.Contains(item))
                    {
                        products.Insert(0, item);
                    }
                }
                else if (action == "Unnecessary")
                {
                    string item = commands[1];
                    if (products.Contains(item))
                    {
                        products.Remove(item);
                    }
                }
                else if (action == "Correct")
                {
                    string oldItem = commands[1];
                    string newItem = commands[2];
                    if (products.Contains(oldItem))
                    {
                        int IndexOFOld = products.IndexOf(oldItem);
                        products[IndexOFOld] = newItem;
                    }
                }
                else if (action == "Rearrange")
                {
                    string item = commands[1];
                    if (products.Contains(item))
                    {
                        int IndexOFOld = products.IndexOf(item);
                        products.RemoveAt(IndexOFOld);
                        products.Add(item);
                    }
                }
            }
            Console.Write(String.Join(", ", products));
        }
    }
}