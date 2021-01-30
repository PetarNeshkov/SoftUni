using System;
using System.Globalization;

namespace Day_of_Week_Objects_and_Classes___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime Date = DateTime.ParseExact(date, "d-M-yyyy",
                CultureInfo.InvariantCulture);
            Console.WriteLine(Date.DayOfWeek);
        }
    }
}
