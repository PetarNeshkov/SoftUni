using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine().Split("@").Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split().ToArray();

            int lastPosition = 0;

            while (command[0] != "Love!")
            {
                int length = int.Parse(command[1]);

                int currentIndex = lastPosition + length;

                if (currentIndex >= houses.Count)
                {
                    currentIndex = 0;
                }

                if (houses[currentIndex] > 0)
                {
                    houses[currentIndex] -= 2;

                    if (houses[currentIndex] == 0)
                    {
                        Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                    }
                }
                else
                {
                    Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                }

                lastPosition = currentIndex;

                command = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine($"Cupid's last position was {lastPosition}.");

            if (houses.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int count = houses.Count(points => points > 0);

                Console.WriteLine($"Cupid has failed {count} places.");
            }
        }
    }
}