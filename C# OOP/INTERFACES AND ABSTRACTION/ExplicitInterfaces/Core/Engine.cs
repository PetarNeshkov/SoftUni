
using ExplicitInterfaces.Interfaces;
using ExplicitInterfaces.Models;
using System;

namespace ExplicitInterfaces.Core
{
   public class Engine
    {
        public void Run()
        {
            string input;
            while ((input=Console.ReadLine())!="End")
            {
                string[] split = input.Split();
                PrintName(split);
            }
        }

        private static void PrintName(string[] split)
        {
            string name = split[0];
            string country = split[1];
            int age = int.Parse(split[2]);

            IPerson person = new Citizen(name,country,age);
            Console.WriteLine(person.GetName());

            IResident resident = new Citizen(name, country, age);
            Console.WriteLine((resident.GetName()));
        }
    }
}
