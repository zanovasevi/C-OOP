using System;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Models.Cars.Entities
{
    public class SportsCar : Car
    {
        private const int cubicCentimeters = 3000;
        private const int minHP = 250;
        private const int maxHP = 450;

        private int horsePower;

        public SportsCar(string model, int horsePower)
            : base(model, horsePower)
        {
            
        }


        public override int HorsePower
        {
            get => horsePower;
            protected set
            {
                if (value < minHP || value > maxHP)
                {
                    string msg = string.Format(ExceptionMessages.InvalidHorsePower, HorsePower);
                    throw new ArgumentException(msg);
                }
                horsePower = value;
            }
        }

        public override double CubicCentimeters { get => cubicCentimeters; }
    }
}
