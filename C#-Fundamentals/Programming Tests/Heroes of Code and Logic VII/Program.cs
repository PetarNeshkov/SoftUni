using System;
using System.Collections.Generic;
using System.Linq;

namespace Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int Maxhealth = 100;
            int Maxmana = 200;

            Dictionary<string, List<int>> dc = new Dictionary<string, List<int>>();
            for (int i = 0; i < counter; i++)
            {
                string[] information = Console.ReadLine().Split();
                string name = information[0];
                int health = int.Parse(information[1]);
                int mana = int.Parse(information[2]);

                health = health > Maxhealth ? Maxhealth : health;
                mana = mana > Maxmana ? Maxmana : mana;

                dc.Add(name, new List<int>() { health, mana });
            }
            string input = " ";
            while ((input = Console.ReadLine()) != "End")
            {
                string[] information = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string action = information[0];
                if (action == "CastSpell")
                {
                    string heroName = information[1];
                    int manaNeeded = int.Parse(information[2]);
                    string spellName = information[3];
                    if (dc[heroName][1] >= manaNeeded)
                    {
                        dc[heroName][1] -= manaNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {  dc[heroName][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (action == "TakeDamage")
                {
                    string heroName = information[1];
                    int damage = int.Parse(information[2]);
                    string attacker = information[3];
                    dc[heroName][0] -= damage;
                    if (dc[heroName][0] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {(dc[heroName][0])} HP left!");
                    }
                    else
                    {
                        dc.Remove(heroName);
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }
                else if (action == "Recharge")
                {
                    string heroName = information[1];
                    int amount = int.Parse(information[2]);
                    if (dc[heroName][1] + amount > Maxmana)
                    {
                        Console.WriteLine($"{heroName} recharged for {200 - dc[heroName][1]} MP!");
                        dc[heroName][1] = Maxmana;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                        dc[heroName][1] += amount;
                    }
                }
                else if (action=="Heal")
                {
                    string heroName = information[1];
                    int amount = int.Parse(information[2]);
                    if (dc[heroName][0] + amount > Maxhealth)
                    {
                        Console.WriteLine($"{heroName} healed for {100 - dc[heroName][0]} HP!");
                        dc[heroName][0] = Maxhealth;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                        dc[heroName][0] += amount;
                    }
                }
            }
            foreach (var item in dc.OrderByDescending(Hp=>Hp.Value[0])
                .ThenBy(name=>name.Key))
            {
                Console.WriteLine($"{item.Key}");
                Console.WriteLine($"  HP: {item.Value[0]}");
                Console.WriteLine($"  MP: {item.Value[1]}");
            }
        }
    }
}
