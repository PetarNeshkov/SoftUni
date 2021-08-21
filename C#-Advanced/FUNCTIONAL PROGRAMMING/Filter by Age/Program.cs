using System;

namespace Filter_by_Age
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int counter =int.Parse(Console.ReadLine());
            Person[] people = new Person[counter];
            for (int i = 0; i < counter; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                people[i] = new Person()
                {
                    Name = input[0],
                    Age = int.Parse((input[1]))   
                };
            }
            string condition = Console.ReadLine();
            int Age =int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> conditionDelegate = Getcondition(condition,Age);
            Action<Person> printerDelegate = Pointer(format);
            foreach (var person in people)
            {
                if (conditionDelegate(person))
                {
                    printerDelegate(person);
                }
            }
        }
        static Func<Person,bool> Getcondition(string condition,int age)
        {
            switch (condition)
            {
                case "younger":
                    return p => p.Age < age;
                case "older":
                    return p => p.Age >= age;
                default:
                    return null;
            }
        }
        static Action<Person> Pointer(string format)
        {
            switch (format)
            {
                case "name":
                    return p => { Console.WriteLine($"{p.Name}"); };
                case "age":
                    return p => { Console.WriteLine($"{p.Age}"); };
                case "name age":
                    return p => { Console.WriteLine($"{p.Name} - {p.Age}"); };
                default:
                    return null;
            }
        }
    }
}
