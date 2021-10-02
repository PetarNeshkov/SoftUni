using System;

namespace Generic_Count_Method_Double
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();
            for (int i = 0; i < n; i++)
            {
                double number =double.Parse(Console.ReadLine());
                box.Add(number);
            }
            double numberToCheck =double.Parse(Console.ReadLine());
            int count=box.Check(numberToCheck);
            Console.WriteLine(count);
        }
    }
}
