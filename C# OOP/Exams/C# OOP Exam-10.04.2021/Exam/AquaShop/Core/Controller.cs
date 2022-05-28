using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private DecorationRepository decorationRepository;
        private List<IAquarium> aquariums;
        public Controller()
        {
            decorationRepository = new DecorationRepository();
            aquariums = new List<IAquarium>();
        }
        public string AddAquarium(string aquariumType, string aquariumName)
        {
            IAquarium aquarium = null;

            if (aquariumType== "FreshwaterAquarium")
            {
                aquarium = new FreshwaterAquarium(aquariumName);
            }
            else if (aquariumType== "SaltwaterAquarium")
            {
                aquarium = new SaltwaterAquarium(aquariumName);
            }
            else
            {
                throw new InvalidOperationException("Invalid aquarium type.");
            }

            aquariums.Add(aquarium);

            return $"Successfully added {aquarium.GetType().Name}.";
        }

        public string AddDecoration(string decorationType)
        {
            IDecoration decoration = null;
            if (decorationType== "Ornament")
            {
                decoration = new Ornament();
            }
            else if (decorationType== "Plant")
            {
                decoration = new Plant();
            }
            else
            {
                throw new InvalidOperationException("Invalid decoration type.");
            }

            decorationRepository.Add(decoration);

            return $"Successfully added {decorationType}.";
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            IFish fish = null;
            var aquarium = aquariums.FirstOrDefault(x => x.Name == aquariumName);

            if (fishType== "FreshwaterFish")
            {
                fish = new FreshwaterFish(fishName, fishSpecies, price);

            }
            else if (fishType== "SaltwaterFish")
            {
                fish = new SaltwaterFish(fishName, fishSpecies, price);
            }
            else
            {
                throw new InvalidOperationException("Invalid fish type.");
            }


            if (fishType == "FreshwaterFish")
            {
                if (aquarium.GetType().Name != "FreshwaterAquarium")
                {
                    return "Water not suitable.";
                }
            }
            else if (fishType== "SaltwaterFish")
            {
                if (aquarium.GetType().Name != "SaltwaterAquarium")
                {
                    return "Water not suitable.";
                }
            }

            aquarium.AddFish(fish);

            return $"Successfully added {fishType} to {aquariumName}.";
        }

        public string CalculateValue(string aquariumName)
        {
            var aquarium = aquariums.FirstOrDefault(x => x.Name == aquariumName);

            decimal sum = 0;

            foreach (var fish in aquarium.Fish)
            {
                sum += fish.Price;
            }

            foreach (var decoration in aquarium.Decorations)
            {
                sum += decoration.Price;
            }

            return $"The value of Aquarium {aquariumName} is {sum:F2}.";
        }

        public string FeedFish(string aquariumName)
        {
            var aquarium = aquariums.FirstOrDefault(x => x.Name == aquariumName);

            int count = 0;
            foreach (var fish in aquarium.Fish)
            {
                count++;
                fish.Eat();
            }

            return $"Fish fed: {count}";
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            var decoration = decorationRepository.FindByType(decorationType);

            if (decoration==null)
            {
                throw new InvalidOperationException($"There isn't a decoration of type {decorationType}.");
            }

            var aquarium = aquariums.FirstOrDefault(x => x.Name == aquariumName);
            //?

            aquarium.AddDecoration(decoration);
            decorationRepository.Remove(decoration);

            return $"Successfully added {decorationType} to {aquariumName}.";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var aquarium in aquariums)
            {
                sb.AppendLine(aquarium.GetInfo());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
