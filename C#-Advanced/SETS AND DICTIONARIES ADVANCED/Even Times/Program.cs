using System;
using System.Collections.Generic;
using System.Linq;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dc = new Dictionary<int, int>();
            int counter = int.Parse(Console.ReadLine());
            for (int i = 0; i < counter; i++)
            {
                int digit = int.Parse(Console.ReadLine());
                if (!dc.ContainsKey(digit))
                {
                    dc.Add(digit, 0);
                }
                dc[digit]++;
            }
           int num= dc.Where(x => x.Value % 2 == 0).FirstOrDefault().Key;
            Console.WriteLine(num);
        }
    }
}
