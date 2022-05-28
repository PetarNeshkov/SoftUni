using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private string name;
        private List<IDecoration> decorations;
        private List<IFish> fishes;

        protected Aquarium(string name, int capacity)
        {
            decorations = new List<IDecoration>();
            fishes = new List<IFish>();
            Name = name;
            Capacity = capacity;
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Aquarium name cannot be null or empty.");
                }
                name = value;
            }
        }

        public int Capacity { get; private set; }

        public int Comfort => decorations.Select(x => x.Comfort).Sum();

        public ICollection<IDecoration> Decorations => decorations;

        public ICollection<IFish> Fish => fishes;

        public void AddDecoration(IDecoration decoration)
        {
            decorations.Add(decoration);
        }

        public void AddFish(IFish fish)
        {
            if (Capacity > fishes.Count)
            {
                fishes.Add(fish);
            }
            else
            {
                throw new InvalidOperationException("Not enough capacity.");
            }
        }

        public void Feed()
        {
            foreach (var fish in fishes)
            {
                fish.Eat();
            }
        }

        public string GetInfo()
        {


            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Name} ({GetType().Name}):");
            if (fishes.Count == 0)
            {
                sb.AppendLine($"Fish: none");
            }
            else
            {
                List<string> fishNames = new List<string>();
                foreach (var item in fishes)
                {
                    fishNames.Add(item.Name);
                }

                sb.AppendLine($"Fish: {String.Join(", ", fishNames)}");
            }

            sb.AppendLine($"Decorations: {decorations.Count}");
            sb.AppendLine($"Comfort: {Comfort}");

            return sb.ToString().TrimEnd();
        }

        public bool RemoveFish(IFish fish)
        {
            return fishes.Remove(fish);
        }
    }
}
