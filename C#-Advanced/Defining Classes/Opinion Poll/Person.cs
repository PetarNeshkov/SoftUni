﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Opinion_Poll
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age):this()
        {
            this.Age = age;
        }

        public Person(string name, int age):this(age)
        {
            this.Name = name;
        }
    }
}
