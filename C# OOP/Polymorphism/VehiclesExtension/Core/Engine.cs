using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehiclesExtension.Contracts;
using VehiclesExtension.Models;

namespace VehiclesExtension.Core
{
   public class Engine
    {
        public void Run()
        {
            string[] carArgs = Console.ReadLine().Split().Skip(1).ToArray();
            Car car = CreateCar(carArgs);
            string[]truckArgs= Console.ReadLine().Split().Skip(1).ToArray();
            Truck truck = CreateTruck(truckArgs);
            string[] busArgs = Console.ReadLine().Split().Skip(1).ToArray();
            Bus bus = CreateBus(busArgs);

            int counter =int.Parse(Console.ReadLine());
            for (int i = 0; i < counter; i++)
            {
                MakeCommand(car, truck, bus);
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
        private Car CreateCar(string[]carArgs)
        {
            double fuelQuantity =double.Parse(carArgs[0]);
            double fuelConsumption =double.Parse(carArgs[1]);
            double tankCapacity =double.Parse(carArgs[2]);
            Car Car = new Car(fuelQuantity, fuelConsumption, tankCapacity);
            return Car;
        }
        private Truck CreateTruck(string[] truckArgs)
        {
            double fuelQuantity = double.Parse(truckArgs[0]);
            double fuelConsumption = double.Parse(truckArgs[1]);
            double tankCapacity = double.Parse(truckArgs[2]);
            Truck Truck = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
            return Truck;
        }
        private Bus CreateBus(string[] busArgs)
        {

            double fuelQuantity = double.Parse(busArgs[0]);
            double fuelConsumption = double.Parse(busArgs[1]);
            double tankCapacity = double.Parse(busArgs[2]);
            Bus Bus = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
            return Bus;
        }
        private void MakeCommand(Car car,Truck truck,Bus bus)
        {
            string[] cmdArgs = Console.ReadLine().Split();

            try
            {
                if (cmdArgs[0] == "Drive")
                {
                    double kilometers =double.Parse(cmdArgs[2]);
                    if (cmdArgs[1]=="Car")
                    {
                        Console.WriteLine(car.Drive(kilometers));
                    }
                    else if (cmdArgs[1] == "Truck")
                    {
                        Console.WriteLine(truck.Drive(kilometers));
                    }
                    else if (cmdArgs[1] == "Bus")
                    {
                        Console.WriteLine(bus.Drive(kilometers));
                    }
                }
                else if (cmdArgs[0]=="Refuel")
                {
                    double fuel =double.Parse(cmdArgs[2]);
                    if (cmdArgs[1] == "Car")
                    {
                        car.Refuel(fuel);
                    }
                    else if (cmdArgs[1] == "Truck")
                    {
                        truck.Refuel(fuel);
                    }
                    else if (cmdArgs[1] == "Bus")
                    {
                        bus.Refuel(fuel);
                    }
                }
                else if (cmdArgs[0]=="DriveEmpty")
                {
                    double kilometers = double.Parse(cmdArgs[2]);
                    if (cmdArgs[1] == "Bus")
                    {
                        Console.WriteLine(bus.EmptyBus(kilometers));
                    }
                }
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }       
        }
    }
}
