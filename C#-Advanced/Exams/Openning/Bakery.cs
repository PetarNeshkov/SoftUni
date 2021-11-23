using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        List<Employee> Employees;

        public Bakery(string name, int capacity)
        {
            Employees = new List<Employee>();
            Name = name;
            Capacity = capacity;
        }
        public int Count => Employees.Count;
        public string Name { get; set; }
        public int Capacity { get; set; }

        public void Add(Employee employee)
        {
            if (Employees.Count < Capacity)
            {
                Employees.Add(employee);
            }
        }
        public bool Remove(string name)
        {
            foreach (var person in Employees)
            {
                if (person.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
        public Employee GetOldestEmployee()
        {
            int age = int.MinValue;
            foreach (var persons in Employees)
            {
                if (persons.Age > age)
                {
                    age = persons.Age;
                }
            }
            return Employees.FirstOrDefault(x => x.Age == age);
        }
        public Employee GetEmployee(string name)
        {
            return Employees.FirstOrDefault(x => x.Name == name);
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {Name}:");
            foreach (var employee in Employees)
            {
                sb.AppendLine($"{employee}");
            }
            return sb.ToString();
        }
    }
}
