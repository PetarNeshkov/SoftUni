using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Equality_Logic
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo( Person other)
        {
            int result = 1;
            result = Name.CompareTo(other.Name);
            if (result==0)
            {
                result = Age - other.Age;
            }
            return result;
        }
        public override bool Equals(object obj)
        {
            if (obj!=null && obj is Person other)
            {
                return Name == other.Name && Age == other.Age;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Age.GetHashCode();
        }
    }
}
