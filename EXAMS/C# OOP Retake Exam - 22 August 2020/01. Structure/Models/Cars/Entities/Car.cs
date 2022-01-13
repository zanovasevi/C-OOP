using System;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Models.Cars.Entities
{
    public abstract class Car : ICar
    {
        private const int minModelSymbols = 4;

        private string model;


        public Car(string model, int horsePower)
        {
            Model = model;
            HorsePower = horsePower;
        }


        public string Model
        {
            get => model;
            private set
            {
                if(string.IsNullOrWhiteSpace(value) || value.Length < minModelSymbols)
                {
                    string msg = string.Format(ExceptionMessages.InvalidModel, Model, minModelSymbols);
                    throw new ArgumentException(msg);
                }
                model = value;
            }
        }

        public abstract int HorsePower { get; protected set; }

        public abstract double CubicCentimeters { get; }

        public double CalculateRacePoints(int laps)
        {
            return CubicCentimeters / HorsePower * laps;
        }
    }
}
