using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Man> people = new List<Man>();

            var command = Console.ReadLine();
            while (command != "End")
            {
                var input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Man student = new Man(input[0], int.Parse(input[1]), int.Parse(input[2]));
                people.Add(student);

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(Environment.NewLine, people.OrderBy(x => x.Age)));
        }
    }
    public class Man
    {
        public string FirstName { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }
        public Man(string firstName, int id, int age)
        {
            this.FirstName = firstName;
            this.ID = id;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"{FirstName} with ID: {ID} is {Age} years old.";
        }
    }
}






