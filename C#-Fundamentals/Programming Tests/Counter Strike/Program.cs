using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            string input = "";
            int battles = 0;
            while ((input = Console.ReadLine()) != "End of battle")
            {
                int enemyDistance = int.Parse(input);
                if (initialEnergy < enemyDistance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battles} won battles and {initialEnergy} energy");
                    return;
                }
                initialEnergy -= enemyDistance;
                battles++;
                if (battles % 3 == 0)
                {
                    initialEnergy += battles;
                }
            }
            Console.WriteLine($"Won battles: {battles}. Energy left: {initialEnergy}");
        }
    }
}