using System;
using System.Text.RegularExpressions;

namespace Extract_Emails_Regular_Expressions___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\s(?<user>[A-Za-z0-9]+[._-]*\w*)*@(?<host>[A-Za-z]+?([.-][A-Za-z]+)*(\.[a-z]{2,}))";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            var matches = regex.Matches(input);
            foreach (Match email in matches)
            {
                Console.WriteLine(email);
            }
        }
    }
}
