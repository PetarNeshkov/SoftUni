
namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double FUEL_CONSUMPTION_INCR = 1.6;
        private const double FuelWastage = 0.95;
        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {
        }
        public override double FuelConsumption
            => base.FuelConsumption + FUEL_CONSUMPTION_INCR;
        public override void Refuel(double fuel)
        {
            base.Refuel(FuelWastage * fuel);
        }
    }
}
