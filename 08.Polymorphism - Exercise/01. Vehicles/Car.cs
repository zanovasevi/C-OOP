using System;
namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double increasedFuelConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption + increasedFuelConsumption)
        {
        }

        public override string Drive(double distance)
        {
            return base.Drive(distance);
        }

        public override void Refuel(double liters)
        {
            FuelQuantity += liters;
        }
    }
}
