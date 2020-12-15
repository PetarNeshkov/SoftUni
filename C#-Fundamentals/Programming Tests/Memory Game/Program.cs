using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Game = Console.ReadLine().Split().ToList();
            string input = "";
            int moves = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                moves++;
                string[] commands = input.Split();
                int firstIndex = int.Parse(commands[0]);
                int secondIndex = int.Parse(commands[1]);
                if (firstIndex >= 0 && secondIndex <= Game.Count - 1 &&
                    firstIndex <= Game.Count - 1 && secondIndex >= 0)
                {
                    if (Game[firstIndex] == Game[secondIndex])
                    {
                        string target1 = Game[firstIndex];
                        string target2 = Game[secondIndex];
                        Console.WriteLine($"Congrats! You have found matching elements - {Game[firstIndex]}!");
                        int findFirst = Game.FindIndex(x => x == target1);
                        Game.RemoveAt(findFirst);
                        int findSecond = Game.FindIndex(x => x == target2);
                        Game.RemoveAt(findSecond);
                    }
                    else
                    {
                        Console.WriteLine(@"Try again!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    string item = "-" + moves.ToString() + "a";
                    Game.Insert(Game.Count / 2, item);
                    Game.Insert(Game.Count / 2, item);
                }

                if (Game.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    return;
                }
            }
            Console.WriteLine($"Sorry you lose :(");
            Console.WriteLine(string.Join(" ", Game));
        }
    }
}