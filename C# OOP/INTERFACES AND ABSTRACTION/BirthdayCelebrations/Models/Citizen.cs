using BirthdayCelebrations.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations.Models
{
    public class Citizen : IIdentifiable, IBirthable
    {
        public Citizen(string name, int age, string id, string birtdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birtdate = birtdate;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }

        public string Id { get; private set; }
        public string Birtdate { get; private set; }

    }
}
