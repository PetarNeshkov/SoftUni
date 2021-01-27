using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards_Game_List_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Player1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> Player2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (Player1.Count > 0 && Player2.Count > 0)
            {
                if (Player1[0] > Player2[0])
                {
                    int numberOfPlayer1 = Player1[0];
                    int numberOfPlayer2 = Player2[0];
                    Player1.RemoveAt(0);
                    Player2.RemoveAt(0);
                    Player1.Add(numberOfPlayer1);
                    Player1.Add(numberOfPlayer2);

                    if (Player2.Count == 0)
                    {
                        Console.WriteLine($"First player wins! Sum: {Player1.Sum()}");
                        return;
                    }
                }
                else if (Player1[0] < Player2[0])
                {
                    int numberOfPlayer1 = Player1[0];
                    int numberOfPlayer2 = Player2[0];
                    Player1.RemoveAt(0);
                    Player2.RemoveAt(0);
                    Player2.Add(numberOfPlayer1);
                    Player2.Add(numberOfPlayer2);
                    if (Player1.Count == 0)
                    {
                        Console.WriteLine($"Second player wins! Sum: {Player2.Sum()}");

                    }
                }
                else
                {
                    Player1.RemoveAt(0);
                    Player2.RemoveAt(0);
                    if (Player1.Count == 0)
                    {
                        Console.WriteLine($"Second player wins! Sum: {Player2.Sum()}");
                        return;
                    }
                    else if (Player2.Count == 0)
                    {
                        Console.WriteLine($"First player wins! Sum: {Player1.Sum()}");
                        return;
                    }
                }

            }


        }
    }
}
    

