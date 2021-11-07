using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int daturaCount = 0;
            int cherryCount = 0;
            int smokeDecoyCount = 0;
            int[] bombEffectArgs = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] bombCasingsArgs = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Queue<int> bombEffect = new Queue<int>(bombEffectArgs);
            Stack<int> bombCasing = new Stack<int>(bombCasingsArgs);
            bool success = false;
            while (bombEffect.Any() && bombCasing.Any())
            {
                int currbombEffect = bombEffect.Peek();
                int currbombCasing = bombCasing.Peek();
                int sum = currbombCasing + currbombEffect;
                switch (sum)
                {
                    case 40:
                        daturaCount++;
                        bombEffect.Dequeue();
                        bombCasing.Pop();
                        break;
                    case 60:
                        cherryCount++;
                        bombEffect.Dequeue();
                        bombCasing.Pop();
                        break;
                    case 120:
                        smokeDecoyCount++;
                        bombEffect.Dequeue();
                        bombCasing.Pop();
                        break;
                    default:
                        currbombCasing -= 5;
                        bombCasing.Pop();
                        bombCasing.Push(currbombCasing);
                        break;
                }
                if (daturaCount>=3 && cherryCount>=3 && smokeDecoyCount>=3)
                {
                    success = true;
                    break;
                }
            }
            if (success)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffect.Any())
            {
                Console.WriteLine($"Bomb Effects: {String.Join(", ",bombEffect)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (bombCasing.Any())
            {
                Console.WriteLine($"Bomb Casings: {String.Join(", ",bombCasing)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            Console.WriteLine($"Cherry Bombs: {cherryCount}");
            Console.WriteLine($"Datura Bombs: {daturaCount}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyCount}");

        }
    }
}
