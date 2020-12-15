using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int waitingPeople = int.Parse(Console.ReadLine());
            int[] currentStateOfLift = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int peopleToReorganise = 0;
            bool gameOver = false;
            for (int i = 0; i < currentStateOfLift.Length; i++)
            {
                if (currentStateOfLift[i] < 4)
                {
                    int diff = 4 - currentStateOfLift[i];
                    if (waitingPeople >= 4)
                    {
                        waitingPeople -= diff;
                        currentStateOfLift[i] += diff;
                    }
                    else
                    {
                        currentStateOfLift[i] += waitingPeople;
                        waitingPeople -= diff;
                    }
                    if (waitingPeople <= 0)
                    {
                        gameOver = true;
                        break;
                    }
                }
                else
                {
                    peopleToReorganise = currentStateOfLift[i] - 4;
                    waitingPeople += peopleToReorganise;
                    currentStateOfLift[i] = 4;
                }
            }
            bool empty = true;
            foreach (var item in currentStateOfLift)
            {
                if (item != 4)
                {
                    empty = false;
                    break;
                }
            }
            if (gameOver && !empty)
            {
                Console.WriteLine($"The lift has empty spots!");
                Console.WriteLine(String.Join(" ", currentStateOfLift));
            }
            else if (!gameOver && empty)
            {
                Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
                Console.WriteLine(String.Join(" ", currentStateOfLift));
            }
            else
            {
                Console.WriteLine(String.Join(" ", currentStateOfLift));
            }
        }
    }
}