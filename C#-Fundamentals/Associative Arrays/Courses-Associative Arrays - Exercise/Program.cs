using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses_Associative_Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while ((input=Console.ReadLine())!="end")
            {
                string[] information = input.Split(" : ");
                string course = information[0];
                string name = information[1];
                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string> { name });
                }
                else
                {
                    if (!courses[course].Contains(name))
                    {
                        courses[course].Add(name);
                    }
                }
            }
            foreach (var course in courses.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var item in course.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
