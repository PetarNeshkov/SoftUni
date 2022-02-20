using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animal
{
    class Cat : Feline
    {
        public Cat(string name, double weight, string livingregion, string breed) 
            : base(name, weight, livingregion, breed)
        {
        }

        public override double WeightMultiplier => 0.30;

        public override ICollection<Type> PrefferedFoods
            => new List<Type>(){typeof(Vegetable),typeof(Meat)};

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
