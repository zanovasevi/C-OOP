using System;
namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double increasedFuelConsumption = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption + increasedFuelConsumption)
        {
        }


        public override string Drive(double distance)
        {
            return base.Drive(distance);
        }

        public override void Refuel(double liters)
        {
            FuelQuantity += liters * 0.95;
        }
    }
}
