using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pokemon
{
   public class Trainer
    {
        private List<Pokemon> pokemons;
        public Trainer(string name)
        {
            Name = name;
            NumberOfBadges = 0;
            pokemons = new List<Pokemon>();
        }
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public void Add(Pokemon pokemon)
        {
            pokemons.Add(pokemon);
        }
         public void Check(string element)
        {
            bool hasPokemon = false;
            foreach (var pokemon in pokemons)
            {
                if (pokemon.Element==element)
                {
                    NumberOfBadges++;
                    hasPokemon = true;
                    break;
                }
            }
            if (!hasPokemon)
            {
                foreach (var pokemon in pokemons)
                {
                    pokemon.Health -= 10;
                }
            }
            pokemons = pokemons.Where(x => x.Health > 0).ToList();
        }
        public override string ToString()
        {
            return $"{Name} {NumberOfBadges} {pokemons.Count}";
        }
    }

}
