using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
namespace Fast_Hash_Implementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = 10000;
            int containsCount = 10000;
            List<string> list = new List<string>();
            HashSet<string> hash = new HashSet<string>(count);
            StringHashSet ourHash = new StringHashSet(count);
            for (int i = 0; i < count; i++)
            {
                list.Add(i.ToString());
                hash.Add(i.ToString());
                ourHash.Add(i.ToString());
            }
            Console.WriteLine("Start!");
            var timer = Stopwatch.StartNew();
            for (int i = 0; i < containsCount; i++)
            {
               bool exists= list.Contains(i.ToString());
            }
            timer.Stop();
            Console.WriteLine("List sucks!");
            Console.WriteLine(timer.ElapsedMilliseconds);
            timer.Reset();
            timer.Start();
            for (int i = 0; i < containsCount; i++)
            {
                bool exists = hash.Contains(i.ToString());
            }
            timer.Stop();
            Console.WriteLine("C# one is ok");
            Console.WriteLine(timer.ElapsedMilliseconds);
            timer.Reset();
            timer.Start();
            for (int i = 0; i < containsCount; i++)
            {
                bool exists = ourHash.Contains(i.ToString());
            }
            timer.Stop();
            Console.WriteLine("Our is best!");
            Console.WriteLine(timer.ElapsedMilliseconds);
            timer.Reset();
            timer.Start();
        }
        static string GenerateString(int lenght=8)
        {
            StringBuilder sb = new StringBuilder();
            Random rand = new Random();
            for (int i = 0; i <lenght ; i++)
            {
                sb.Append(rand.Next(0,9));
            }
            return sb.ToString();
        }
    }
}
