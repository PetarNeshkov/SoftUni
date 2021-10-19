using System;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
   public class ListyIterator<T>
    {
        private List<T> Information;
        private int index=0;
        public ListyIterator(params T[] elements)
        {
            this.Information = new List<T>();

        }
        public bool Move()
        {
            if (index+1<Information.Count)
            {
                index++;
                return true;
            }
            return false;
        }
        public bool HasNext()
        {
            if (index+1<Information.Count)
            {
                return true;
            }
            return false;
        }
        public void Print()
        {
            if (Information.Count==0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else if(index>=0 && index < Information.Count)
            {
                Console.WriteLine(Information[index]);
            }
        }
        public void Add(T item)
        {
            Information.Add(item);
        }

    }
}
