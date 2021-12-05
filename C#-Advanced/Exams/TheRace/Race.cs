using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
   public class Race
    {
        private List<Racer> racers;

        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            racers = new List<Racer>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public void Add(Racer racer)
        {
            if (Capacity>racers.Count)
            {
                racers.Add(racer);
            }
        }
        public  bool Remove(string name)
        {
            var racer = racers.FirstOrDefault(x => x.Name == name);

            return racers.Remove(racer);
        }
        public Racer GetOldestRacer()
        {
            return racers.OrderByDescending(x => x.Age).FirstOrDefault();
        }
        public Racer GetRacer(string name)
        {
            return racers.FirstOrDefault(x => x.Name == name);
        }
        public Racer GetFastestRacer()
        {
            return racers.OrderByDescending(x => x.Car.Speed).FirstOrDefault();
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racers participating at {Name}:");
            foreach (var race in racers)
            {
                sb.AppendLine($"{race}");
            }
            return sb.ToString().TrimEnd();
        }
        public int Count => racers.Count;
    }
}
