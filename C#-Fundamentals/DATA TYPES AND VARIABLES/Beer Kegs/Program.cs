using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int BeerCounter = int.Parse(Console.ReadLine());
            string BiggestModel = string.Empty;
            double BiggestKeg = 0;
            for (int i = 0; i < BeerCounter; i++)
            {
                string model = Console.ReadLine();
                float RadiusOKeg = float.Parse(Console.ReadLine());
                int heightOfKeg = int.Parse(Console.ReadLine());
                double volume = 3.14 *Math.Pow(RadiusOKeg,2) * heightOfKeg;
                if (volume>BiggestKeg)
                {
                    BiggestKeg = volume;
                    BiggestModel = model;
                }
            }
            Console.WriteLine(BiggestModel);
        }
    }
}
