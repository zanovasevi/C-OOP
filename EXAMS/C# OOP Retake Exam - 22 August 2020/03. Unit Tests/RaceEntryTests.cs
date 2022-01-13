using System;
using NUnit.Framework;
using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        UnitCar car;
        UnitDriver driver;
        RaceEntry raceEntry;

        [SetUp]
        public void Setup()
        {
            car = new UnitCar("model", 100, 1000);
            driver = new UnitDriver("name", car);
            raceEntry = new RaceEntry();
        }

        [Test]
        public void UnitCarCtor()
        {
            Assert.AreEqual("model", car.Model);
            Assert.AreEqual(100, car.HorsePower);
            Assert.AreEqual(1000, car.CubicCentimeters);
        }

        [Test]
        public void UnitDriverCtor()
        {
            Assert.AreEqual("name", driver.Name);
            Assert.AreEqual(car, driver.Car);
        }

        [Test]
        public void UnitDriverNameCanNotBeNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                UnitDriver driver = new UnitDriver(null, car);
            });
        }

        [Test]
        public void RaceEntryCtor()
        {
            Assert.AreEqual(0, raceEntry.Counter);
        }

        [Test]
        public void AddNullDriver()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                raceEntry.AddDriver(null);
            });
        }

        [Test]
        public void AddSameDriverName()
        {
            raceEntry.AddDriver(driver);
            UnitDriver driver2 = new UnitDriver("name", new UnitCar("k", 50, 5000));
            

            Assert.Throws<InvalidOperationException>(() =>
            {
                raceEntry.AddDriver(driver2);
            });
        }

        [Test]
        public void AddDriverShouldWotkProperly()
        {
            string result = raceEntry.AddDriver(driver);

            Assert.AreEqual($"Driver {driver.Name} added in race.", result);
        }

        [Test]
        public void MinPartisipantsIncalculateAverageHP()
        {
            raceEntry.AddDriver(driver);

            Assert.Throws<InvalidOperationException>(() =>
            {
                raceEntry.CalculateAverageHorsePower();
            });
        }

        [Test]
        public void CalculateAverageHP()
        {
            raceEntry.AddDriver(driver);
            UnitDriver driver2 = new UnitDriver("name2", new UnitCar("k", 200, 5000));
            raceEntry.AddDriver(driver2);

            double result = raceEntry.CalculateAverageHorsePower();

            Assert.AreEqual(150, result);
        }
    }
}