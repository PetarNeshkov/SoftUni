using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Count_Method_String
{
    public class Box<T> where T : IComparable
    {
        private List<T> information;
        public Box()
        {
            information = new List<T>();
        }
        public void Add(T value)
        {
            information.Add(value);
        }
        public int GetCountOfEl(T value)
        {
            int count = 0;
            foreach (var item in information)
            {
                if (value.CompareTo(item)<0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
