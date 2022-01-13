using System;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        private double defaultfuelConsumption = 8;

        public RaceMotorcycle(int horsePower, double fuel)
            :base(horsePower, fuel)
        {
        }


        public override double FuelConsumption
        {
            get => this.defaultfuelConsumption;
        }
    }
}
