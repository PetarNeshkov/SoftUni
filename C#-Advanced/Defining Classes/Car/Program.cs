using System;

namespace CarManufacturer
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "brum";
            car.Year = 5360;
            car.Model = "BMV";
            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}