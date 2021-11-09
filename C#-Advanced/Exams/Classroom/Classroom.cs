using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        List<Student> students;

        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }
       
        public int Capacity { get; set; }
        public int Count => students.Count;

        public string RegisterStudent(Student student)
        {
            string output;
            if (students.Count < Capacity)
            {
                students.Add(student);
                output = $"Added student {student.FirstName} {student.LastName}";
                return output.Trim();
            }
            output = "No seats in the classroom";
            return output.Trim();
        }
        public string DismissStudent(string firstName, string lastName)
        {
            string output;
            foreach (var person in students)
            {
                if (person.FirstName == firstName && person.LastName == lastName)
                {
                    students.Remove(person);
                    output = $"Dismissed student {firstName} {lastName}";
                    return output.Trim();
                }
            }
            output = "Student not found";
            return output.Trim();
        }
        public string GetSubjectInfo(string subject)
        {
            StringBuilder sb = new StringBuilder();
            var listOfStudents = students.Where(x => x.Subject == subject).ToList();
            if (listOfStudents.Count > 0)
            {
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");
                foreach (var person in listOfStudents)
                {
                    sb.AppendLine($"{person.FirstName} {person.LastName}");
                }
                    return sb.ToString().Trim();
            }
            sb.AppendLine("No students enrolled for the subject");
            return sb.ToString().Trim();
        }
        public int GetStudentsCount() => Count;
        public Student GetStudent(string firstName,string lastName)
        {
            Student name = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
            return name;
        }
    }
}
