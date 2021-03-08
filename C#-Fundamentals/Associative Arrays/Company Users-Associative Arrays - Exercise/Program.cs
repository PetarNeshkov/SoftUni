using System;
using System.Collections.Generic;

namespace Company_Users_Associative_Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            SortedDictionary<string, List<string>> output = new SortedDictionary<string, List<string>>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split(" -> ");
                string company = data[0];
                string user = data[1];
                if (!output.ContainsKey(company))
                {
                    output.Add(company, new List<string>());
                }
                if (!output[company].Contains(user))
                {
                    output[company].Add(user);
                }
            }
            foreach (var company in output)
            {
                Console.WriteLine(company.Key);
                foreach (var users in company.Value)
                {
                    Console.WriteLine($"-- {users}");
                }
            }
        }
    }
}
