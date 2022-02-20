using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animal
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingregion)
            : base(name, weight, livingregion)
        {
        }

        public override double WeightMultiplier => 0.10;

        public override ICollection<Type> PrefferedFoods =>
            new List<Type>() { typeof(Vegetable), typeof(Fruit) };

        public override string ProduceSound()
        {
            return "Squeak";
        }
    }
}
