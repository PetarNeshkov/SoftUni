using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Swap_Method_String
{
    public class Box<T>
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
        public void Swap(int firstIndex,int secondIndex)
        {
            T temp = information[firstIndex];
            information[firstIndex] = information[secondIndex];
            information[secondIndex] = temp;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in information)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }
            return sb.ToString();
        }
    }
}
