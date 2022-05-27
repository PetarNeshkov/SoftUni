using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Computers.Tests
{
    public class Tests
    {
        ComputerManager computerManager;
        Computer computer;
        [SetUp]
        public void Setup()
        {
            computerManager = new ComputerManager();
            computer = new Computer("Samsung", "A31", 2000);
        }

        [Test]
        public void ThrowsExpMessageWIthNullComputer()
        {

            var ex = Assert.Throws<ArgumentNullException>(() =>
            {
                computerManager.AddComputer(null);
            });

          
        }

        [Test]
        public void SameComputerAddedExp()
        {
            computerManager.AddComputer(computer);

            Assert.Throws<ArgumentException>(() =>
             computerManager.AddComputer(computer));

        }

        [Test]
        public void AddComputerShouldWork()
        {
            computerManager.AddComputer(computer);

            var expectedCount = 1;
            var actualCount = computerManager.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void RemoveComputerShouldWorkPropietly()
        {
            computerManager.AddComputer(computer);

            computerManager.RemoveComputer("Samsung", "A31");

            var expectedCount = 0;
            var actualCount = computerManager.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }
        [Test]
        public void RemoveMethodShouldThrowNullExceptionWhenModelIsNull()
        {
            this.computerManager.AddComputer(this.computer);

            Assert.Throws<ArgumentNullException>(() => this.computerManager.RemoveComputer("sony", null));
        }
        [Test]
        public void GetComputerThrowsManifacturerExp()
        {
           
            var ex = Assert.Throws<ArgumentNullException>(() =>
             computerManager.GetComputer(null, "A31")
             );
         
        }

        [Test]
        public void GetComputerThrowsModelExp()
        {
           ;
            var ex = Assert.Throws<ArgumentNullException>(() =>
            computerManager.GetComputer("Samsung", null)
            );
          
        }
        [Test]
        public void GetComputerThrowsNoSuchComputerExp()
        {
            var ex = Assert.Throws<ArgumentException>(() =>
           computerManager.GetComputer("Samsung", "B31")
           );
            Assert.AreEqual("There is no computer with this manufacturer and model.", ex.Message);
        }
        [Test]
        public void GetComputerWorks()
        {
            computerManager.AddComputer(computer);
           var actualResult= computerManager.GetComputer("Samsung", "A31");

            Assert.AreEqual(computer, actualResult);
        }

        [Test]
        public void GetComputersByManufactures()
        {
            computerManager.AddComputer(computer);
            computerManager.AddComputer(new Computer("LG", "A32", 1500));
            computerManager.AddComputer(new Computer("Samsung", "31", 200));
            var collection = computerManager.GetComputersByManufacturer("Samsung");

            Assert.AreEqual(2, collection.Count);
        }
        [Test]
        public void Count()
        {
            computerManager.AddComputer(computer);

            int expectedCount = 1;
            var actualCount = computerManager.Computers.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}