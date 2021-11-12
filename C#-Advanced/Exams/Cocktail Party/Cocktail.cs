using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
   public class Cocktail
    {
        private List<Ingredient> ingredients;

        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
            ingredients = new List<Ingredient>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }

        public void Add(Ingredient ingredient)
        {
            if ((!ingredients.Contains(ingredient))&& Capacity>ingredients.Count &&ingredient.Alcohol<=MaxAlcoholLevel)
            {
                ingredients.Add(ingredient);
            }
        }
        public bool Remove(string name)
        {
            var ingredient = ingredients.FirstOrDefault(x => x.Name == name);

            return ingredients.Remove(ingredient);
        }
        public Ingredient FindIngredient(string name)
        {
            var ingredient = ingredients.FirstOrDefault(x => x.Name == name);

            return ingredient;
        }
        public Ingredient GetMostAlcoholicIngredient()
        {
            var ingredient = ingredients.OrderByDescending(x => x.Alcohol).FirstOrDefault();

            return ingredient;
        }
        public int CurrentAlcoholLevel=> ingredients.Sum(x => x.Alcohol);
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cocktail: {Name} - Current Alcohol Level: {CurrentAlcoholLevel}");
            foreach (var ingredient in ingredients)
            {
                sb.AppendLine($"{ingredient}");
            }
            return sb.ToString().TrimEnd();
        }

    }
}
