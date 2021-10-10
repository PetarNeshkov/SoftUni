using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
    public class ListyIterator<T>:IEnumerable<T>
    {
        private List<T> Information;
        private int index = 0;
        public ListyIterator(params T[] elements)
        {
            this.Information = elements.ToList();

        }
        public bool Move()
        {
            if (index + 1 < Information.Count)
            {
                index++;
                return true;
            }
            return false;
        }
        public bool HasNext()
        {
            if (index + 1 < Information.Count)
            {
                return true;
            }
            return false;
        }
        public void Print()
        {
            if (Information.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else if (index >= 0 && index < Information.Count)
            {
                Console.WriteLine(Information[index]);
            }
        }
        public void Add(T item)
        {
            Information.Add(item);
        }
        public string PrintAll()
        {
            return string.Join(" ", Information);
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in Information)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
