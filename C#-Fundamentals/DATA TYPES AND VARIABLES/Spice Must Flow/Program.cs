using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int daysCounter = 0;
            int sum = 0;
            int CurrentDayMining = 0;
            while (startingYield>=100)
            {
                CurrentDayMining =startingYield - 26;
                sum += CurrentDayMining;
                startingYield -= 10;
                daysCounter++;
            }
            if (sum>=26)
            {
            sum -= 26;
            }
            Console.WriteLine(daysCounter);
            Console.WriteLine(sum);
        }
    }
}
