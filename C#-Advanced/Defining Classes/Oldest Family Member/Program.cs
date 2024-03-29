﻿using System;

namespace Oldest_Family_Member
{
    public class Startup
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            Family listOfPeople = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                listOfPeople.AddMember(person);
            }
            Person oldestPerson = listOfPeople.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}

