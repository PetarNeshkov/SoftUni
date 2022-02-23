
using System;

namespace VehiclesExtension.Models
{
    public class Truck : Vehicle
    {
        private const double fuelConsumptionAmplifier = 1.6;
        private const double fuelWastage = 0.95;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }
        protected override double FuelConsumption 
            => base.FuelConsumption+fuelConsumptionAmplifier;
        public override void Refuel(double refuel)
        {
            if (refuel <= 0)
            {
                throw new ArgumentException(Exceptions.Exceptions.NegativeFuel);
            }

            if (FuelQuantity + refuel > TankCapacity)
            {
                throw new ArgumentException
                    (String.Format(Exceptions.Exceptions.TooMuchFuel, refuel));
            }

            this.FuelQuantity += refuel * fuelWastage;
        }
    }
}
