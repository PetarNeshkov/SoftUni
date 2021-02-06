﻿using System;
using System.Text.RegularExpressions;

namespace Match_Full_Name_Regular_Expressions___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            var matches = regex.Matches(input);
            foreach (Match item in matches)
            {
                Console.Write(item.Value+" ");
            }
        }
    }
}
