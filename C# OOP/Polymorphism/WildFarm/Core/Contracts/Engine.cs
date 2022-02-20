using System;
using System.Collections.Generic;
using System.Linq;
using WildFarm.Core.Factories;
using WildFarm.Models.Animal;
using WildFarm.Models.Foods;

namespace WildFarm.Core
{
   public class Engine
    {
        private ICollection<Animal> animals;
        private readonly AnimalFactory animalFactory;
        private readonly FoodFactory foodFactory;
        public Engine()
        {
            this.animalFactory = new AnimalFactory();
            foodFactory = new FoodFactory();
            animals = new HashSet<Animal>();
        }
        public void Run()
        {
            string command;
            while ((command=Console.ReadLine())!="End")
            {
                string[] animalArgs = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string type = animalArgs[0];
                string name = animalArgs[1];
                double weight =double.Parse(animalArgs[2]);
                string[] args = animalArgs.Skip(3).ToArray();

                Animal animal=null;
                try
                {
                    animal = animalFactory.Create(type, name, weight, args);
                    animals.Add(animal);

                    Console.WriteLine(animal.ProduceSound());
                }
                catch (InvalidOperationException ioe) 
                {
                    Console.WriteLine(ioe.Message);
                }
                string[] foodArgs = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string foodType = foodArgs[0];
                int foodQuantity = int.Parse(foodArgs[1]);

                try
                {
                    Food food = foodFactory.CreateFood(foodType,foodQuantity);

                    if (animal != null)
                    {
                        animal.Feed(food);
                    }
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }
            foreach (var animal in animals)
            { 
                Console.WriteLine(animal);
            }
        }
    }
}
