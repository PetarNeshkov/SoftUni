using System;
using System.Collections.Generic;
using System.Text;

namespace Speed_Racing
{
    class Car
    {
        public Car(string model, double fuelamount, double fuelconsumption)
        {
            Model = model;
            FuelAmount = fuelamount;
            FuelConsumptionPerKilometer = fuelconsumption;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public void driveCheck(int amountOfKm)
        {
            double trip = FuelConsumptionPerKilometer * amountOfKm;
            if (FuelAmount >= trip)
            {
                FuelAmount -= trip;
                TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
