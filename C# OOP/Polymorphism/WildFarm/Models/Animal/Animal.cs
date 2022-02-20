using System;
using System.Collections.Generic;
using WildFarm.Models.Animal.Contracts;
using WildFarm.Models.Foods.Contracts;

namespace WildFarm.Models.Animal
{
    public abstract class Animal : IAnimal,IFeedable,ISoundProducable
    {
    private const string INV_Food_Type = "{0} does not eat {1}!";
        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        public abstract double WeightMultiplier { get; }

        public abstract ICollection<Type> PrefferedFoods { get; }

        public void Feed(IFood food)
        {
            if (!PrefferedFoods.Contains(food.GetType()))
            {
                throw new 
                    InvalidOperationException(String.Format
                    (INV_Food_Type,this.GetType().Name,food.GetType().Name));
            }
            FoodEaten += food.Quantity;
            Weight += food.Quantity * WeightMultiplier;
        }

        public abstract string ProduceSound();
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, ";
        }
    }
}
