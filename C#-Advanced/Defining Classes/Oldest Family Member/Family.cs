using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oldest_Family_Member
{
   public class Family
    {
       private List<Person> people = new List<Person>();

       public void AddMember(Person member)
        {
            people.Add(member);
        }
        public Person GetOldestMember()
         =>people.OrderByDescending(x => x.Age).FirstOrDefault();
    }
}
