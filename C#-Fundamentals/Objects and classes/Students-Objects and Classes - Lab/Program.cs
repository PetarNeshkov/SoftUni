using System;
using System.Collections.Generic;

namespace Students_Objects_and_Classes___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            string input = string.Empty;
            while ((input=Console.ReadLine())!="end")
            {
                string[] data = input.Split();
                string FirstName = data[0];
                string LastName = data[1];
                int Age = int.Parse(data[2]);
                string City = data[3];
                Students student = new Students();
                student.FirstName = FirstName;
                student.LastName = LastName;
                student.Age = Age;
                student.City = City;
                students.Add(student);
            }
            string city = Console.ReadLine();
            foreach (Students student in students)
            {
                if (city==student.City)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName}" +
                        $" is {student.Age} years old.");
                }
            }
        }
    }
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
