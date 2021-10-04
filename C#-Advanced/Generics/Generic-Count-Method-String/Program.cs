using System;

namespace Generic_Count_Method_String
{
  public class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                box.Add(input);
            }
            string comparingEl = Console.ReadLine();
            int count=box.GetCountOfEl(comparingEl);
            Console.WriteLine(count);
        }
    }
}
