using System;
using System.Collections.Generic;
using System.Linq;
using Vehicles.Contracts;
using Vehicles.Models;

namespace Vehicles.Core
{
    public class Engine
    {
        private IVehicle car;
        private IVehicle truck;
        public void Run()
        {
            string[] carArgs = Console.ReadLine().Split().Skip(1).ToArray();
            car = CreateCar(carArgs);
            string[] truckArgs = Console.ReadLine().Split().Skip(1).ToArray();
            truck = CreateTruck(truckArgs);
            int counter = int.Parse(Console.ReadLine());
            for (int i = 0; i < counter; i++)
            {
                try
                {
                    string[] cmdrArgs = Console.ReadLine().Split();
                    string cmdType = cmdrArgs[0];
                    string vehicleType = cmdrArgs[1];
                    if (cmdType == "Drive")
                    {
                        double distance = double.Parse(cmdrArgs[2]);
                        if (vehicleType == "Car")
                        {
                            Console.WriteLine(car.Drive(distance));
                        }
                        else if (vehicleType == "Truck")
                        {
                            Console.WriteLine(truck.Drive(distance));
                        }
                    }
                    else if (cmdType == "Refuel")
                    {
                        double liters = double.Parse(cmdrArgs[2]);
                        if (vehicleType == "Car")
                        {
                            car.Refuel(liters);
                        }
                        else if (vehicleType == "Truck")
                        {
                            truck.Refuel(liters);
                        }
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
        private IVehicle CreateCar(string[] carArgs)
        {
            double fuelQuantity = double.Parse(carArgs[0]);
            double fuelConsumption = double.Parse(carArgs[1]);
            Car car = new Car(fuelQuantity, fuelConsumption);
            return car;
        }
        private IVehicle CreateTruck(string[] truckArgs)
        {
            double fuelQuantity = double.Parse(truckArgs[0]);
            double fuelConsumption = double.Parse(truckArgs[1]);
            Truck truck = new Truck(fuelQuantity, fuelConsumption);
            return truck;
        }
    }
}
