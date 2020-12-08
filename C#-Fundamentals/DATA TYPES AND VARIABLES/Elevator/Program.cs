using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int sumOfPeople = 0;
            int courses = 0;
            while (numberOfPeople>sumOfPeople)
            {
                sumOfPeople += capacity;
                courses++;
            }
            Console.WriteLine(courses);
        }
    }
}
