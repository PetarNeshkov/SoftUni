using System;
using System.Linq;

namespace Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(numbers, (x, y) =>
             {
                 int sort = -1;
                 if (x % 2 == 0 && y % 2 != 0)
                 {
                     sort = -1;
                 }
                 else if (x % 2 != 0 && y % 2 == 0)
                 {
                     sort = 1;
                 }
                 else
                 {
                     sort = x - y;
                     //y.CompareTo(x);
                 }
                 return sort;
             });
            //Array.Sort(numbers, (x, y) => (x % 2 == 0 && y % 2 != 0) ? -1 :
            //(x % 2 != 0 && y % 2 == 0) ? 1
            //: x.CompareTo(y));

            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
