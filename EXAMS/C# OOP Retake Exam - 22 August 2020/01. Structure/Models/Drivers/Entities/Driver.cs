using System;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Models.Drivers.Entities
{
    public class Driver : IDriver
    {
        private const int minNameSymbols = 5;

        private string name;
        private bool canParticipate = false;

        public Driver()
        {
            Name = name;
            CanParticipate = canParticipate;
        }


        public string Name
        {
            get => name;
            private set
            {
                if(string.IsNullOrEmpty(value) || value.Length < minNameSymbols)
                {
                    string msg = string.Format(ExceptionMessages.InvalidName, Name);
                    throw new ArgumentException(msg);
                }
                name = value;
            }
        }

        public ICar Car { get; private set; }

        public int NumberOfWins { get; private set; }

        public bool CanParticipate { get; private set; }

        public void AddCar(ICar car)
        {
            if(car == null)
            {
                throw new ArgumentNullException(ExceptionMessages.CarInvalid);
            }
            Car = car;
            CanParticipate = true;
        }

        public void WinRace()
        {
            NumberOfWins++;
        }
    }
}
