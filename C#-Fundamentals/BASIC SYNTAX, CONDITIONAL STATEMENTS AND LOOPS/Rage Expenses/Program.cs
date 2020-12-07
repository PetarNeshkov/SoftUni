using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double expenses = headsetPrice * (lostGames / 2);
            expenses += mousePrice * (lostGames / 3);
            expenses += keyboardPrice * (lostGames / 6);
            expenses += displayPrice * (lostGames / 12);
            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
