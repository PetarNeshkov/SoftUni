using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        public int age;

        public string Name { get; private set; }

        public int Age
        {
            get => this.age;

            protected set
            {
                if (value < 1)
                {
                    throw new InvalidOperationException("Invalid input!");
                }

                this.age = value;
            }
        }
        public string Gender { get; private set; }
        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public abstract string ProduceSound();
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{GetType().Name}")
               .AppendLine($"{Name} {Age} {Gender}")
               .AppendLine($"{ProduceSound()}");
            return sb.ToString().TrimEnd();
        }
    }
}
