﻿using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animal
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingregion)
            : base(name, weight, livingregion)
        {
        }

        public override double WeightMultiplier => 0.40;

        public override ICollection<Type> PrefferedFoods
            => new List<Type>() { typeof(Meat) };

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
