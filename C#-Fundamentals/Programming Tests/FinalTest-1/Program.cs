using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string String = Console.ReadLine();
            string input = "";
            while ((input = Console.ReadLine()) != "Done")
            {
                string[] tokens = input.Split();
                string action = tokens[0];
                if (action == "Change")
                {
                    string number = tokens[1];
                    string replacement = tokens[2];
                    String = String.Replace(number, replacement);
                    Console.WriteLine(String);
                }
                else if (action == "Includes")
                {
                    string otherString = tokens[1];
                    if (String.Contains(otherString))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (action == "End")
                {
                    string otherString = tokens[1];
                    if (String.EndsWith(otherString))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (action == "Uppercase")
                {
                    String = String.ToUpper();
                    Console.WriteLine(String);
                }
                else if (action == "FindIndex")
                {
                    string toFind = tokens[1];
                    int index = String.IndexOf(toFind);
                    Console.WriteLine(index);
                }
                else if (action == "Cut")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int length = int.Parse(tokens[2]);
                    string sub = String.Substring(startIndex, length);
                    String = String.Replace(String, "");
                    String = sub;
                    Console.WriteLine(String);
                }
            }
        }
    }
}