using System;
using System.Collections.Generic;
using System.Linq;

namespace Speed_Racing
{
  public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                int fuelAmount = int.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);
                Car car = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(car);
            }
            string command = "";
            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command.Split();
                string carModel = input[1];
                int amountOfKm = int.Parse(input[2]);
                Car car = cars.FirstOrDefault(x => x.Model == carModel);
                car.driveCheck(amountOfKm);
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
