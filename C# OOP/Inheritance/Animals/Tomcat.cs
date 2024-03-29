﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tomcat : Cat
    {
        private const string TomcatDefaultGender = "Male";

        public Tomcat(string name, int age) : base(name, age, TomcatDefaultGender)
        {
        }
        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
