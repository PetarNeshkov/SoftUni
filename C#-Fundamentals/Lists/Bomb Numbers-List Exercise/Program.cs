using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers_List_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Bomb = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombNumber = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int specialBombNumber = bombNumber[0];
            int BombPower = bombNumber[1];
            for (int i = 0; i < Bomb.Count; i++)
            {
                if (Bomb[i]==specialBombNumber)
                {
                    int LeftDetonation = i - BombPower;
                    if (LeftDetonation<0)
                    {
                        LeftDetonation = 0;
                    }
                    int RightDirection = i + BombPower;
                    if (RightDirection>Bomb.Count)
                    {
                        RightDirection = Bomb.Count - 1;
                    }
                    Bomb.RemoveRange(LeftDetonation, RightDirection-LeftDetonation+1);
                }
            }
            Console.WriteLine($"{Bomb.Sum()}");
        }
    }
}
