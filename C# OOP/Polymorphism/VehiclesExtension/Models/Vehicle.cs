
using System;
using VehiclesExtension.Contracts;

namespace VehiclesExtension.Models
{
    public abstract class Vehicle : IVehicle
    {
        private const string TravelledDistance= "{0} travelled {1} km";

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity > tankCapacity ? 0 : fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        protected double FuelQuantity { get; set; }
        protected virtual double FuelConsumption { get; set; }

        protected double TankCapacity { get;  }

        double IVehicle.FuelQuantity => throw new NotImplementedException();

        double IVehicle.FuelConsumption => throw new NotImplementedException();

        double IVehicle.TankCapacity => throw new NotImplementedException();

        public string Drive(double kilometers)
        {
            double distance = kilometers * FuelConsumption;
            if (distance>FuelQuantity)
            {
                throw
                    new ArgumentException
                    (String.Format(Exceptions.Exceptions.NeededFuelMessage,GetType().Name));
            }
            FuelQuantity -= distance;
            return String.Format(TravelledDistance,GetType().Name,kilometers);
        }

        public virtual void Refuel(double refuel)
        {
            if (refuel<=0)
            {
                throw new ArgumentException(Exceptions.Exceptions.NegativeFuel);
            }
            if (FuelQuantity + refuel>TankCapacity)
            {
                throw new ArgumentException
                    (String.Format(Exceptions.Exceptions.TooMuchFuel,refuel));
            }
            FuelQuantity += refuel;        
        }
        public override string ToString()
        {
            return $"{GetType().Name}: {FuelQuantity:F2}";
        }
    }
}
