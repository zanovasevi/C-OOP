using System;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Models.Cars.Entities
{
    public class MuscleCar : Car
    {
        private const int cubicCentimeters = 5000;
        private const int minHP = 400;
        private const int maxHP = 600;

        private int horsePower;

        public MuscleCar(string model, int horsePower)
            : base(model, horsePower)
        {
            
        }


        public override int HorsePower
        {
            get => horsePower;
            protected set
            {
                if(value < minHP || value > maxHP)
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
