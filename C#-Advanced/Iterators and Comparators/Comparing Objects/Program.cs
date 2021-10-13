using System;
using System.Collections.Generic;

namespace Comparing_Objects
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Person> people = new List<Person>();
            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];
                Person person = new Person(name, age, town);
                people.Add(person);
            }
            int n = int.Parse(Console.ReadLine());
            Person PersonToCheck = people[n - 1];
            int matchedPeople = 0;
            foreach (var person in people)
            {
                if (person.CompareTo(PersonToCheck) == 0)
                {
                    matchedPeople++;
                }
            }
            if (matchedPeople == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matchedPeople} {people.Count - matchedPeople} {people.Count}");
            }
        }
    }
}
