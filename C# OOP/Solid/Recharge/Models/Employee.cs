using Recharge.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recharge.Models
{
    public class Employee : Worker, ISleeper
    {
        public Employee(string id) : base(id)
        {
        }

        public void Sleep()
        {
        }
    }
}