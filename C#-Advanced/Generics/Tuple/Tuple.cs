using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
   public class Tuple<TFirst,TSecond>
    {
       private TFirst Item1 { get; set; }
        private TSecond Item2 { get; set; }
        public Tuple(TFirst firstItem,TSecond secondItem)
        {
            Item1 = firstItem;
            Item2 = secondItem;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Item1} -> {Item2}");
            return sb.ToString();
        }
    }
}
