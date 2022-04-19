using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding.Core
{
    public class Engine
    {
        private const string InvalidHeroMsgExp = "Invalid hero!";
        public void Run()
        {
            ICollection<BaseHero> raiders = new HashSet<BaseHero>();
            BaseHero hero;

            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            while (counter != n)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                try
                {
                    hero = CreateHero(name, type);

                    counter++;

                    raiders.Add(hero);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            long bossPower = long.Parse(Console.ReadLine());

            foreach (var currhero in raiders)
            {
                Console.WriteLine(currhero.CastAbility());
            }
            long allPower = raiders.Select(x => x.Power).Sum();

            if (allPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }

        private static BaseHero CreateHero(string name, string type)
        {
            BaseHero hero;
            if (type == "Druid")
            {
                hero = new Druid(name);
            }
            else if (type == "Paladin")
            {
                hero = new Paladin(name);
            }
            else if (type == "Rogue")
            {
                hero = new Rogue(name);
            }
            else if (type == "Warrior")
            {
                hero = new Warrior(name);
            }
            else
            {
                throw new ArgumentException(InvalidHeroMsgExp);
            }

            return hero;
        }
    }
}
