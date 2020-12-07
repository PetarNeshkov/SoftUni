using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());
            double FinalSum = 0;


            int freeBelt = studentsCount / 6;

            double TotalLightsabers = Math.Ceiling(studentsCount + studentsCount * 0.10) * priceOfLightsaber;
            double TotalRobes = studentsCount * priceOfRobe;
            double TotalBelts = priceOfBelt * studentsCount - freeBelt * priceOfBelt;

            FinalSum = TotalBelts + TotalLightsabers + TotalRobes;
            if (money >= FinalSum)
            {
                Console.WriteLine($"The money is enough - it would cost {FinalSum:F2}lv.");
            }
            else
            {
                FinalSum -= money;
                Console.WriteLine($"Ivan Cho will need {FinalSum:F2}lv more.");
            }
        }
    }
}