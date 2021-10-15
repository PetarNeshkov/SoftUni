using System;
using System.Collections.Generic;

namespace Equality_Logic
{
   public class Program
    {
        static void Main(string[] args)
        {
            HashSet<Person> hashpeople = new HashSet<Person>();
            SortedSet<Person> sortedHash = new SortedSet<Person>();
            int n =int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                hashpeople.Add(person);
                sortedHash.Add(person);
            }
            Console.WriteLine(hashpeople.Count);
            Console.WriteLine(sortedHash.Count);

        }
    }
}
