using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm
{
   public class Chicken
    {
        private const string INVALID_NAME_EXC_MSG = "Name cannot be empty.";
        private const string INVALID_AGE_EXC_MSG = "Age should be between 0 and 15.";
        private string name;
        private int age;
        public Chicken(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get => this.name;

            private set
            {
                ValidatorName(value);
                name = value;
            }
        }

        public int Age
        {
            get => this.age;

            private set
            {
                ValidatorAge(value);
                age = value;
            }
        }
        private void ValidatorName(string paramName)
        {
            if (string.IsNullOrEmpty(paramName)||string.IsNullOrWhiteSpace(paramName))
            {
                throw new ArgumentException($"{INVALID_NAME_EXC_MSG}");
            }
        }
        private void ValidatorAge(int age)
        {
            if (age<0 || age>15)
            {
                throw new ArgumentException($"{INVALID_AGE_EXC_MSG}");
            }
        }
        private double CalculateProductPerDay()
        {
            switch (this.Age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
        }
        public double ProductPerDay
            => CalculateProductPerDay();

        public override string ToString()
        {
            return $"Chicken {this.Name} (age {this.Age}) can produce {this.ProductPerDay} eggs per day.";
        }

    }
}
