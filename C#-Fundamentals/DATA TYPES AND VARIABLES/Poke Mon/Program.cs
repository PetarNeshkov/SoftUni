using System;
using System.Numerics;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowBallNumber = int.Parse(Console.ReadLine());
            int BiggestsnowballSnow = 0, BiggestsnowballTime = 0, BiggestsnowballQuality = 0;
            BigInteger  BiggestsnowballValue = 0;
            for (int i = 0; i < snowBallNumber; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger division = snowballSnow / snowballTime;
                BigInteger snowballValue=BigInteger.Pow(division, snowballQuality);
                if (snowballValue>BiggestsnowballValue)
                {
                    BiggestsnowballValue = snowballValue;
                    BiggestsnowballSnow = snowballSnow;
                    BiggestsnowballTime = snowballTime;
                    BiggestsnowballQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{BiggestsnowballSnow} : {BiggestsnowballTime} = {BiggestsnowballValue} ({BiggestsnowballQuality})");
        }
    }
}
