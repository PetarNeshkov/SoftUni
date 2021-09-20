using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon
{
  public class StartUp
    {
        static void Main(string[] args)
        {
            string input = "";
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] split = input.Split();
                string trainneName = split[0];
                string pokemonName = split[1];
                string pokemonElement = split[2];
                int pokemonHealth = int.Parse(split[3]);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                if (!trainers.ContainsKey(trainneName))
                {
                    trainers.Add(trainneName, new Trainer(trainneName));
                }
                trainers[trainneName].Add(pokemon);
            }
            while ((input = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers.Values)
                {
                    trainer.Check(input);
                }
            
            }
            List<Trainer> result = trainers.Values
               .OrderByDescending(x => x.NumberOfBadges)
               .ToList();
            foreach (var trainer in result)
            {
                Console.WriteLine(trainer);
            }
        }
    }
}
