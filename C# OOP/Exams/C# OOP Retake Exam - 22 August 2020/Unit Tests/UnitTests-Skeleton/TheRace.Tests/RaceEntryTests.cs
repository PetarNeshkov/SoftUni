using NUnit.Framework;
using System;
using System.Collections.Generic;
using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        [SetUp]
        public void Setup()
        {
        }      
        [Test]
        public void AddDriverShouldThrowExcpWhenItsNull()
        {
            var RaceEntry = new RaceEntry();
            Assert.Throws<InvalidOperationException>(() =>RaceEntry.AddDriver(null));
        }

        [Test]
        public void AddDriverShouldThrowExcpWhenAlreadyExists()
        {
            var RaceEntry = new RaceEntry();
            UnitCar car = new UnitCar("Tesla", 100, 2000.1);
            UnitDriver unitDriver = new UnitDriver("Gosho", car);
            RaceEntry.AddDriver(unitDriver);

            Assert.Throws<InvalidOperationException>(()=>RaceEntry.AddDriver(unitDriver));
        }

        [Test]
        public void AddDriverShouldWorkPropietly()
        {
            var RaceEntry = new RaceEntry();
            UnitCar car = new UnitCar("Tesla", 100, 2000.1);
            UnitDriver unitDriver = new UnitDriver("Gosho", car);

           var result= RaceEntry.AddDriver(unitDriver);

            Assert.AreEqual(String.Format("Driver {0} added in race.",unitDriver.Name),result);
            Assert.AreEqual(1, RaceEntry.Counter);
        }

        [Test]
        public void CalculateAverageHorsePowerShouldThrowExceptionWhenParticipantsAreNotEnough()
        {
            var RaceEntry = new RaceEntry();
            UnitCar car = new UnitCar("Tesla", 100, 2000.1);
            UnitDriver unitDriver = new UnitDriver("Gosho", car);

            var result = RaceEntry.AddDriver(unitDriver);

            Assert.Throws<InvalidOperationException>(()=>RaceEntry.CalculateAverageHorsePower());

        }

        [Test]
        public void CalculateAverageHorsePowerShouldWorkPropietly()
        {
            var RaceEntry = new RaceEntry();
            UnitCar car1 = new UnitCar("Tesla", 100, 2000.1);
            UnitCar car2 = new UnitCar("Tesla", 100, 2000.1);
            UnitCar car3 = new UnitCar("Tesla", 100, 2000.1);

            UnitDriver unitDriver1 = new UnitDriver("Gosho", car1);
            UnitDriver unitDriver2 = new UnitDriver("Dancho", car2);
            UnitDriver unitDriver3 = new UnitDriver("Teemo", car3);

            RaceEntry.AddDriver(unitDriver1);
            RaceEntry.AddDriver(unitDriver2);
            RaceEntry.AddDriver(unitDriver3);

            int expectedResult = 100;
            var actualResult = RaceEntry.CalculateAverageHorsePower();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}