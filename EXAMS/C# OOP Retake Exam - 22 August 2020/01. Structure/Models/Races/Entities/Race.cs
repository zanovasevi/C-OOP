using System;
using System.Collections.Generic;
using System.Linq;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Models.Races.Entities
{
    public class Race : IRace
    {
        private const int minNameSymbols = 5;
        private const int minLaps = 1;

        private string name;
        private int laps;
        private ICollection<IDriver> drivers;

        public Race()
        {
            Name = name;
            Laps = laps;
            drivers = new List<IDriver>();
        }



        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < minNameSymbols)
                {
                    string msg = string.Format(ExceptionMessages.InvalidName, Name);
                    throw new ArgumentException(msg);
                }
                name = value;
            }
        }

        public int Laps
        {
            get => laps;
            private set
            {
                if(value < minLaps)
                {
                    string msg = string.Format(ExceptionMessages.InvalidNumberOfLaps, minLaps);
                    throw new ArgumentException(msg);
                }
                laps = value;
            }
        }

        public IReadOnlyCollection<IDriver> Drivers { get => drivers.ToList().AsReadOnly(); }

        public void AddDriver(IDriver driver)
        {
            if(driver == null)
            {
                throw new ArgumentNullException(ExceptionMessages.DriverInvalid);
            }
            if(driver.CanParticipate == false)
            {
                string msg = string.Format(ExceptionMessages.DriverNotParticipate, driver.Name);
                throw new ArgumentException(msg);
            }
            if(drivers.Any(x => x.Name == driver.Name))
            {
                string msg = string.Format(ExceptionMessages.DriverAlreadyAdded, driver.Name, this.Name);
                throw new ArgumentNullException(msg);
            }

            drivers.Add(driver);
        }
    }
}
