using System;
using System.Collections.Generic;
using System.Text;

namespace DetailPrinter.Models
{
    public class Employee
    {
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public override string ToString() => this.Name;
    }
}
