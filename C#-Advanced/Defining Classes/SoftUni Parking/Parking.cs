using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        public List<Car> cars;
        public int capacity;
        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.cars = new List<Car>();
        }
        public int Count => cars.Count;
        public string AddCar(Car car)
        {
            bool exists = cars.Any(x => x.RegistrationNumber == car.RegistrationNumber);
            if (exists)
            {
                return "Car with that registration number, already exists!";
            }
            else if (cars.Count >=capacity)
            {
                return $"Parking is full!";
            }
            else
            {
                this.cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";

            }
        }
        public string RemoveCar(string RegistrationNumber)
        {
            Car car = cars.FirstOrDefault(x => x.RegistrationNumber == RegistrationNumber);
            if (car != null)
            {
                cars.Remove(car);
                return $"Successfully removed {RegistrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }
        public Car GetCar(string RegistrationNumber)
        => cars.FirstOrDefault(x => x.RegistrationNumber == RegistrationNumber);
        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (var regNumber in RegistrationNumbers)
            {
                Car car = cars.FirstOrDefault(x => x.RegistrationNumber == regNumber);
                cars.Remove(car);
            }
        }
    }
}
