using CarManager;
using NUnit.Framework;
using System;

[TestFixture]
public class CarTests
{

    [Test]
    [TestCase("Volswaggen", "Golf", 10, 100)]
    public void ConstructorWorkingFine(
        string make, string model, double FuelConsumption, double FuelCapacity)
    {
        Car car = new Car(make, model, FuelConsumption, FuelCapacity);

        Assert.AreEqual(make, car.Make);
        Assert.AreEqual(model, car.Model);
        Assert.AreEqual(FuelConsumption, car.FuelConsumption);
        Assert.AreEqual(FuelCapacity, car.FuelCapacity);
    }
    [Test]
    public void SuccessfullyAddedFuelAmount()
    {
        int expectedFuelAmount = 0;
        int actualFuelAmount = 0;
        Assert.AreEqual(expectedFuelAmount, actualFuelAmount);
    }
    [Test]
    [TestCase(null)]
    [TestCase("")]
    public void MakeException(string make)
        => Assert.Throws<ArgumentException>(() => new Car(make, "Golf", 10, 100));
    [Test]
    [TestCase(null)]
    [TestCase("")]
    public void ModelException(string model)
        => Assert.Throws<ArgumentException>(() => new Car("Volswaggen", model, 10, 100));
    [Test]
    [TestCase(0)]
    [TestCase(-1)]
    public void FuelConsumptionException(double fuelConsumption)
        => Assert.Throws<ArgumentException>(() => new Car("Volswaggen", "Golf", fuelConsumption, 100));
    [Test]
    [TestCase(0)]
    [TestCase(-1)]
    public void FuelCapacityException(double fuelCapacity)
        => Assert.Throws<ArgumentException>(() => new Car("Volswaggen", "Golf", 10, fuelCapacity));

    [Test]
    [TestCase(-1)]
    public void FuelAmountCannotBeNegative(double actualFuelAmount)
    {
        int expectectedFuelAmount = 0;
        Assert.AreNotEqual(expectectedFuelAmount, actualFuelAmount);
    }

    [Test]
    [TestCase(20)]
    public void SuccessfullyRefueled(double fuelToRefuel)
    {
        Car car = new Car("Volswaggen", "Golf", 10, 100);
        car.Refuel(20);

        int expectedResult = 20;
        double actualResult = car.FuelAmount;
        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    [TestCase(0)]
    [TestCase(-1)]
    public void ZeroOrNegativeRefuelException(double fuelToRefuel)
    {
        Car car = new Car("Volswaggen", "Golf", 10, 100);
        Assert.Throws<ArgumentException>(() => car.Refuel(fuelToRefuel));
    }

    [Test]
    [TestCase(120)]
    public void CarFuelAmountShouldNotBeMoreThanFuelCapacity(double fuelToRefuel)
    {
        Car car = new Car("Volswaggen", "Golf", 10, 100);
        car.Refuel(120);
        int expectedResult = 100;
        double actualResult = car.FuelAmount;
        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    [TestCase(500)]
    public void SuccessfullyDrived(double distance)
    {
        Car car = new Car("Volswaggen", "Golf", 10, 100);

        car.Refuel(100);
        car.Drive(distance);

        double expectedResult = car.FuelAmount;
        double actualResult = 50;
        Assert.AreEqual(expectedResult, actualResult);
    }
    [Test]
    [TestCase(500)]
    public void NotEnoughFuelException(double distance)
    {
        Car car = new Car("Volswaggen", "Golf", 10, 100);

        Assert.Throws<InvalidOperationException>(() => car.Drive(distance));
    }

}
