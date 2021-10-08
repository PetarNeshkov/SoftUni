using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
   public class Threeuple<TFirst,TSecond,TThird>
    {
        TFirst item1 { get; set; }
        TSecond item2 { get; set; }
        TThird item3 { get; set; }
        public Threeuple(TFirst firstItem,TSecond secondItem,TThird thirdItem)
        {
            item1 = firstItem;
            item2 = secondItem;
            item3 = thirdItem;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{item1} -> {item2} -> {item3}");
            return sb.ToString();
        }
    }
}
