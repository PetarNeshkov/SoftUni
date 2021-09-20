using System;
using System.Collections.Generic;
using System.Linq;

namespace Raw_Data
{
    public class RawData
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];

                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Tire[] tires = new Tire[4];
                int counter = 0;
                for (int j = 5; j < input.Length; j += 2)
                {
                    double tirePressure = double.Parse(input[j]);
                    int tireAge = int.Parse(input[j + 1]);
                    Tire tire = new Tire(tirePressure, tireAge);
                    tires[counter++] = tire;
                }

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                cars = cars.Where(x => x.Cargo.CargoType == "fragile" && x.Tires.Any(x => x.TirePressure < 1)).ToList();
            }
            else if (command == "flamable")
            {
                cars = cars.Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250).ToList();
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car.Model);
            }

        }
    }
}
