using System;
using Vehicles.Contracts;
using Vehicles.Common;
namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        private const string TravelledDistance = "{0} travelled {1} km";


        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; private set; }

        public virtual double FuelConsumption { get; }

        public string Drive(double distance)
        {
            double fuelNeeded = FuelConsumption * distance;
            if (FuelQuantity < fuelNeeded)
            {
                throw new
                    InvalidOperationException(
                    String.Format(ExceptionMessages.NotEnoughFuel, GetType().Name));
            }
            FuelQuantity -= fuelNeeded;
            return String.Format(TravelledDistance, GetType().Name, distance);
        }

        public virtual void Refuel(double fuel)
        {
            FuelQuantity += fuel;
        }
        public override string ToString()
        {
            return $"{GetType().Name}: {FuelQuantity:F2}";
        }
    }
}
