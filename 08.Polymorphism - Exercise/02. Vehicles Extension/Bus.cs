using System;
namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double withPeople = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override string DriveEmpty(double distance)
        {
            return base.Drive(distance);
        }

        public override string Drive(double distance)
        {
            if (distance * (FuelConsumption + withPeople) <= FuelQuantity)
            {
                FuelQuantity -= distance * (FuelConsumption + withPeople);
                return $"{GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{GetType().Name} needs refueling";
            }
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
