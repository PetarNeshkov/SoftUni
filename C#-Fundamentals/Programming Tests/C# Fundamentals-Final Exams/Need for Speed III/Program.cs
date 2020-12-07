using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();
            int counter = int.Parse(Console.ReadLine());
            string input = "";
            for (int i = 0; i < counter; i++)
            {
                string[] commands = Console.ReadLine().Split("|").ToArray();
                string car = commands[0];
                int distance = int.Parse(commands[1]);
                int fuel = int.Parse(commands[2]);
                if (!cars.ContainsKey(car))
                {
                    cars.Add(car, new List<int> { distance, fuel });
                }
                else
                {
                    cars[car][0] += distance;
                    cars[car][1] += fuel;
                }
            }
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] commands = input.Split(" : ").ToArray();
                string action = commands[0];
                if (action == "Drive")
                {
                    string car = commands[1];
                    int distance = int.Parse(commands[2]);
                    int fuel = int.Parse(commands[3]);
                    if (cars[car][1] < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        cars[car][0] += distance;
                        cars[car][1] -= fuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }
                    if (cars[car][0] >= 100000)
                    {
                        Console.WriteLine($"Time to sell the {car}!");
                        cars.Remove(car);
                    }
                }
                else if (action == "Refuel")
                {
                    string car = commands[1];
                    int fuel = int.Parse(commands[2]);
                    if (cars[car][1] + fuel <= 75)
                    {
                        cars[car][1] += fuel;
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }
                    else
                    {
                        Console.WriteLine($"{car} refueled with {75 - cars[car][1]} liters");
                        cars[car][1] = 75;
                    }
                }
                else if (action == "Revert")
                {
                    string car = commands[1];
                    int kilometers = int.Parse(commands[2]);
                    cars[car][0] -= kilometers;
                    if (cars[car][0] < 10000)
                    {
                        cars[car][0] = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                }
            }
            foreach (var car in cars.OrderByDescending(milage => milage.Value[0])
                .ThenBy(car => car.Key))
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
        }
    }
}

