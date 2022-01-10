using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {

        public string FirstName { get;private set; }
        public string SecondName { get;private set; }
        public int Age { get;private set; }
        public decimal Salary { get;private set; }
        public Person(string firstName, string secondName, int age, decimal salary)
        {
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
            Salary = salary;
        }
        public void IncreaseSalary(decimal percentage)
        {
            if (Age<30)
            {
                Salary += percentage * Salary / 200;
            }
            else
            {
                Salary += percentage * Salary / 100;
            }
        }
        public override string ToString()
        {
            return $"{FirstName} {SecondName} receives {Salary:F2} leva.";
        }
    }
}
