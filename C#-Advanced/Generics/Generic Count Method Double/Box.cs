using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Count_Method_Double
{
   public class Box<T> where T:IComparable
    {
        private List<T> information;
        public Box()
        {
            information = new List<T>();
        }
        public void Add(T input)
        {
            information.Add(input);
        }
        public int Check(T number)
        {
            int count = 0;
            foreach (var currNumber in information)
            {
                if (currNumber.CompareTo(number)>0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
