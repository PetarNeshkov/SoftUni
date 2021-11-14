using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liquids = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] ingredients = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(ingredients);//ingredients
            Queue<int> queue = new Queue<int>(liquids);//liqueds

            int BreadCount = 0;
            int CakeCount = 0;
            int PastryCount = 0;
            int FruitPieCount = 0;

            while (stack.Any() && queue.Any())
            {
                int firstLiquid = queue.Peek();
                int lastIngredient = stack.Peek();
                int sum = firstLiquid + lastIngredient;
                switch (sum)
                {
                    case 25:
                        BreadCount++;
                        stack.Pop();
                        queue.Dequeue();
                        break;
                    case 50:
                        stack.Pop();
                        queue.Dequeue();
                        CakeCount++;
                        break;
                    case 75:
                        stack.Pop();
                        queue.Dequeue();
                        PastryCount++;
                        break;
                    case 100:
                        stack.Pop();
                        queue.Dequeue();
                        FruitPieCount++;
                        break;
                    default:
                        queue.Dequeue();
                        lastIngredient +=3;
                        stack.Pop();
                        stack.Push(lastIngredient);
                        break;
                }
            }
            if (BreadCount!=0 && CakeCount !=0 && PastryCount !=0 && FruitPieCount!=0)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (queue.Count==0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {String.Join(", ",queue)}");
            }

            if (stack.Count==0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.WriteLine($"Ingredients left: {String.Join(", ",stack)}");
            }

            Console.WriteLine($"Bread: {BreadCount}");
            Console.WriteLine($"Cake: {CakeCount}");
            Console.WriteLine($"Fruit Pie: {FruitPieCount}");
            Console.WriteLine($"Pastry: {PastryCount}");
        }
    }
}
