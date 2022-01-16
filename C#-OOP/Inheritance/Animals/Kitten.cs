using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Kitten : Cat
    {
        private const string KittenDefaultGender = "Female";

        public Kitten(string name, int age) : base(name, age,KittenDefaultGender)
        {
        }
        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
