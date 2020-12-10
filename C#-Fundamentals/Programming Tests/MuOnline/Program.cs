using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] field = Console.ReadLine().Split("|").ToArray();
            int bitcoins = 0;
            int initialHealth = 100;
            int counter = 0;
            for (int i = 0; i < field.Length; i++)
            {
                string[] commands = field[i].Split();
                string itemsOrmonster = commands[0];
                int number = int.Parse(commands[1]);
                if (itemsOrmonster == "potion")
                {
                    if (initialHealth + number <= 100)
                    {
                        Console.WriteLine($"You healed for {number} hp.");
                        initialHealth += number;
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {100 - initialHealth} hp.");
                        initialHealth = 100;
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                        counter++;
                    }
                }
                else if (itemsOrmonster == "chest")
                {
                    Console.WriteLine($"You found {number} bitcoins.");
                    bitcoins += number;
                    counter++;
                }
                else
                {
                    initialHealth -= number;
                    counter++;
                    if (initialHealth <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {itemsOrmonster}.");
                        Console.WriteLine($"Best room: {counter}");
                        return;
                    }
                    Console.WriteLine($"You slayed {itemsOrmonster}.");
                }
            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {initialHealth}");
        }
    }
}