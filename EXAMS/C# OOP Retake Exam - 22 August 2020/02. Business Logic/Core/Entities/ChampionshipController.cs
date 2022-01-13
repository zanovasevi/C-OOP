using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasterRaces.Core.Contracts;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Cars.Entities;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Drivers.Entities;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Models.Races.Entities;
using EasterRaces.Repositories.Entities;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Core.Entities
{
    public class ChampionshipController : IChampionshipController
    {
        private const int minPartisipants = 3;

        private DriverRepository drivers;
        private CarRepository cars;
        private RaceRepository races;

        public ChampionshipController()
        {
            drivers = new DriverRepository();
            cars = new CarRepository();
            races = new RaceRepository();
        }


        public string AddCarToDriver(string driverName, string carModel)
        {
            IDriver driver = drivers.GetAll().FirstOrDefault(x => x.Name == driverName);
            ICar car = cars.GetAll().FirstOrDefault(x => x.Model == carModel);

            if(driver == null)
            {
                string msg = string.Format(ExceptionMessages.DriverNotFound, driverName);
                throw new InvalidOperationException(msg);
            }

            if (car == null)
            {
                string msg = string.Format(ExceptionMessages.CarNotFound, carModel);
                throw new InvalidOperationException(msg);
            }

            driver.AddCar(car);
            string outputMsg = string.Format(OutputMessages.CarAdded, driverName, carModel);
            return outputMsg;
        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            IRace race = races.GetAll().FirstOrDefault(x => x.Name == raceName);
            IDriver driver = drivers.GetAll().FirstOrDefault(x => x.Name == driverName);

            if (race == null)
            {
                string msg = string.Format(ExceptionMessages.RaceNotFound, raceName);
                throw new InvalidOperationException(msg);
            }

            if (driver == null)
            {
                string msg = string.Format(ExceptionMessages.DriverNotFound, driverName);
                throw new InvalidOperationException(msg);
            }

            race.AddDriver(driver);
            string outputMsg = string.Format(OutputMessages.DriverAdded, driverName, raceName);
            return outputMsg;
        }

        public string CreateCar(string type, string model, int horsePower)
        {
            if (cars.GetAll().Any(x => x.Model == model))
            {
                string msg = string.Format(ExceptionMessages.CarExists, model);
                throw new ArgumentException(msg);
            }

            ICar car = null;
            if(type == "Muscle")
            {
                car = new MuscleCar(model, horsePower);
            }
            else if (type == "Sports")
            {
                car = new SportsCar(model, horsePower);
            }

            cars.Add(car);
            string outputMsg = string.Format(OutputMessages.CarCreated, car.GetType().Name, model);
            return outputMsg;
        }

        public string CreateDriver(string driverName)
        {
            if(drivers.GetAll().Any(x => x.Name == driverName))
            {
                string msg = string.Format(ExceptionMessages.DriversExists, driverName);
                throw new ArgumentException(msg);
            }

            IDriver driver = new Driver(driverName);
            drivers.Add(driver);

            string outputMsg = string.Format(OutputMessages.DriverCreated, driverName);
            return outputMsg;
        }

        public string CreateRace(string name, int laps)
        {
            if(races.GetAll().Any(x => x.Name == name))
            {
                string msg = string.Format(ExceptionMessages.RaceExists, name);
                throw new InvalidOperationException(msg);
            }

            IRace race = new Race(name, laps);
            races.Add(race);

            string outputMsg = string.Format(OutputMessages.RaceCreated, name);
            return outputMsg;
        }

        public string StartRace(string raceName)
        {
            if(!races.GetAll().Any(x => x.Name == raceName))
            {
                string msg = string.Format(ExceptionMessages.RaceNotFound, raceName);
                throw new InvalidOperationException(msg);
            }

            IRace race = races.GetAll().FirstOrDefault(x => x.Name == raceName);
            if(race.Drivers.Count < minPartisipants)
            {
                string msg = string.Format(ExceptionMessages.RaceInvalid, raceName, minPartisipants);
                throw new InvalidOperationException(msg);
            }

            int laps = race.Laps;
            var fastestDrivers = race.Drivers.OrderByDescending(x => x.Car.CalculateRacePoints(laps)).Take(3).ToList();

            int count = 1;
            StringBuilder sb = new StringBuilder();
            foreach(var driver in fastestDrivers)
            {
                if(count == 1)
                {
                    sb.AppendLine($"Driver {driver.Name} wins {race.Name} race.");
                }
                else if(count == 2)
                {
                    sb.AppendLine($"Driver {driver.Name} is second in {race.Name} race.");
                }
                else if(count == 3)
                {
                    sb.AppendLine($"Driver {driver.Name} is third in {race.Name} race.");
                }

                count++;
            }
            races.Remove(race);
            return sb.ToString().Trim();
        }
    }
}
