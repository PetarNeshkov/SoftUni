﻿
namespace VehiclesExtension.Models
{
    public class Car : Vehicle
    {
        private const double fuelConsumptionAmplifier =0.9;
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }
        protected override double FuelConsumption 
            => base.FuelConsumption+fuelConsumptionAmplifier;

    }
}
