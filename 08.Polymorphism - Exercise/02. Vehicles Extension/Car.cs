using System;
namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double increasedFuelConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption + increasedFuelConsumption, tankCapacity)
        {
        }

        public override string Drive(double distance)
        {
            return base.Drive(distance);
        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            if (liters + FuelQuantity > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                return;
            }
            FuelQuantity += liters;
        }
    }
}
