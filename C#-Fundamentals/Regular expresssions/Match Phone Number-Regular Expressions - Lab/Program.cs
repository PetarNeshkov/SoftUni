using System;
using System.Text.RegularExpressions;

namespace Match_Phone_Number_Regular_Expressions___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359([ -\\])2\1\d{3}\1\d{4}\b";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            var matches = regex.Matches(input);

            Console.Write(String.Join(", ", matches));
        }
    }
}
