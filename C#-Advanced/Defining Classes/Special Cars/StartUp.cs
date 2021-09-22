using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = "";
            List<Tire[]> ListOftires = new List<Tire[]>();
            List<Engine> ListOfEngines = new List<Engine>();
            List<Car> ListOfCars = new List<Car>();
            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] tires = input.Split();
                Tire[] currTires = new Tire[4]
                {
                 new Tire(int.Parse(tires[0]), double.Parse(tires[1])),
                 new Tire(int.Parse(tires[2]), double.Parse(tires[3])),
                 new Tire(int.Parse(tires[4]), double.Parse(tires[5])),
                 new Tire(int.Parse(tires[6]), double.Parse(tires[7]))
            };
                ListOftires.Add(currTires);
            }
            while ((input = Console.ReadLine()) != "Engines done")
            {
                double[] engines = input.Split().Select(double.Parse).ToArray();

                int horsePower = (int)(engines[0]);
                double pressure = engines[1];
                Engine currEngine = new Engine(horsePower, pressure);
                ListOfEngines.Add(currEngine);
            }
            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] cars = input.Split();
                string Name = cars[0];
                string model = cars[1];
                int year = int.Parse(cars[2]);
                double fuelQuantity = double.Parse(cars[3]);
                double fuelConsumption = double.Parse(cars[4]);
                int engineIndex = int.Parse(cars[5]);
                int tiresIndex = int.Parse(cars[6]);
                Car currCar = new Car(Name, model, year, fuelQuantity, fuelConsumption, ListOfEngines[engineIndex], ListOftires[tiresIndex]);
                ListOfCars.Add(currCar);
            }
            string result = SpecialCars(ListOfCars);
            Console.WriteLine(result);
        }
        public static string SpecialCars(List<Car> cars)
        {
            List<Car> spcialCars = cars
                .Where(x => x.Year >= 2017)
                .Where(x => x.Engine.HorsePower > 330)
                .Where(x => x.Tires.Sum(y => y.Pressure) >= 9 && x.Tires.Sum(y => y.Pressure) <= 10)
                .ToList();
            StringBuilder result = new StringBuilder();
            foreach (var car in spcialCars)
            {
                car.Drive(20);
                result.AppendLine($"Make: {car.Make}");
                result.AppendLine($"Model: {car.Model}");
                result.AppendLine($"Year: {car.Year}");
                result.AppendLine($"HorsePowers: {car.Engine.HorsePower}");
                result.AppendLine($"FuelQuantity: {car.FuelQuantity}");
            }
            return result.ToString();
        }

    }
}
