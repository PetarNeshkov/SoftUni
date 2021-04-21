using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            double coins, sumOfCoins = 0;
            while ((input = Console.ReadLine()) != "Start")
            {
                coins = double.Parse(input);
                if (!(coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2))
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                else
                {
                    sumOfCoins += coins;
                }
            }
            while ((input = Console.ReadLine()) != "End")
            {
                string product = input;
                double price = 0;
                switch (product)
                {
                    case "Nuts":
                        price = 2;
                        sumOfCoins -= price;
                        if (sumOfCoins >= 0)
                        {
                            Console.WriteLine("Purchased nuts");
                        }
                        else Console.WriteLine("Sorry, not enough money");
                        continue;
                    case "Water":
                        price = 0.7;
                        sumOfCoins -= price;
                        if (sumOfCoins >= 0)
                        {
                            Console.WriteLine("Purchased water");
                        }
                        else Console.WriteLine("Sorry, not enough money");
                        continue;
                    case "Crisps":
                        price = 1.5;
                        sumOfCoins -= price;
                        if (sumOfCoins >= 0)
                        {
                            Console.WriteLine("Purchased crisps");
                        }
                        else Console.WriteLine("Sorry, not enough money");
                        continue;
                    case "Soda":
                        price = 0.8;
                        sumOfCoins -= price;
                        if (sumOfCoins >= 0)
                        {
                            Console.WriteLine("Purchased soda");
                        }
                        else Console.WriteLine("Sorry, not enough money");
                        continue;
                    case "Coke":
                        price = 1;
                        sumOfCoins -= price;
                        if (sumOfCoins >= 0)
                        {
                            Console.WriteLine("Purchased coke");
                        }
                        else Console.WriteLine("Sorry, not enough money");
                        continue;
                    default:
                        Console.WriteLine("Invalid product");
                        continue;
                }
            }
            Console.WriteLine($"Change: {Math.Abs(sumOfCoins):F2}");
        }
    }
}