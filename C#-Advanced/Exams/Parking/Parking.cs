using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
   public class Parking
    {
        private ICollection<Car> cars;

        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            cars = new List<Car>();
        }

        public string Type { get;private set; }
        public int Capacity { get;private set; }
        public int Count => cars.Count;
        public void Add(Car car)
        {
            if (cars.Count<Capacity)
            {
                cars.Add(car);
            }
        }
        public bool Remove(string manufacturer,string model)
        {
            Car carToCheck = cars.FirstOrDefault(x => x.Manufacturer == manufacturer 
            && x.Model == model);
            if (carToCheck!=null)
            {
                cars.Remove(carToCheck);
                return true;
            }
            return false;
        }
        public Car GetLatestCar()
        {
            int maxValue = int.MinValue;
            Car carToCheck = cars.FirstOrDefault(x => x.Year > maxValue);
            if (carToCheck!=null)
            {
                return carToCheck;
            }
            return null;
        }
        public Car GetCar(string manufacturer,string model)
        {
            Car carToCheck = cars.FirstOrDefault(x => x.Manufacturer == manufacturer
             && x.Model == model);
            if (carToCheck!=null)
            {
                return carToCheck;
            }
            return null;
        }
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {Type}:");
            foreach (var car in cars)
            {
                sb.AppendLine($"{car}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
