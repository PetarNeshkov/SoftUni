using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations.Contracts
{
   public interface IBirthable
    {
        public string Name { get; }
        public string Birtdate { get; }
    }
}
