using System;

namespace DateModifier
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier();
            int result = dateModifier.GetDayDifference(startDate, endDate);
            Console.WriteLine(Math.Abs(result));
        }
    }
}
