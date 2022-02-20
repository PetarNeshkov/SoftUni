
using VehiclesExtension.Contracts;

namespace VehiclesExtension.Models
{
    public class Bus : Vehicle,IBus
    {
        private const double airconditioner= 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption+airconditioner, tankCapacity)
        {
        }
        public string EmptyBus(double kilometers)
        {
            FuelConsumption -= airconditioner;
            return base.Drive(kilometers);
        }
    }
}
