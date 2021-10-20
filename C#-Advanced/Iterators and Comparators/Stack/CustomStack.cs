using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        public Stack()
        {
            Information = new List<T>();
        }
        private List<T> Information;

        public void Push(T element)
        {
            Information.Insert(Information.Count,element);
        }
        public void Pop()
        {
            if (Information.Count != 0)
            {
                Information.RemoveAt(Information.Count-1);
            }
            else
            {
                Console.WriteLine("No elements");
            }

        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Information.Count-1; i >=0 ; i--)
            {
                yield return Information[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
             return this.GetEnumerator();
        }
    }
}
