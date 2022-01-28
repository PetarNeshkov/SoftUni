using BirthdayCelebrations.Contracts;
using BirthdayCelebrations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BirthdayCelebrations.Core
{
    public class Engine
    {
        private readonly ICollection<IBirthable> birthables;
        public Engine()
        {
            birthables = new List<IBirthable>();
        }
        public void Run()
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] split = input.Split();
                string name = split[0];
                split = split.Skip(1).ToArray();
                if (name == "Pet")
                {
                    AddPet(split);
                }
                else if (name == "Citizen")
                {
                    AddCitizen(split);
                }
            }
            string targetYear = Console.ReadLine();
            PrintMatrix(targetYear);
            
        }

        private void PrintMatrix(string targetYear)
        {
            birthables.Where(x => x.Birtdate.EndsWith(targetYear))
                            .ToList().ForEach(x => { Console.WriteLine(x.Birtdate);});
        }

        private void AddPet(string[] petArgs)
        {
            string PetName = petArgs[0];
            string birthDay = petArgs[1];
            IBirthable pet = new Pet(PetName, birthDay);
            birthables.Add(pet);
        }
        private void AddCitizen(string[] citizenArgs)
        {
            string CitizenName = citizenArgs[0];
            int age = int.Parse(citizenArgs[1]);
            string id = citizenArgs[2];
            string birthdate = citizenArgs[3];
            IBirthable citizen = new Citizen(CitizenName, age, id, birthdate);
            birthables.Add(citizen);
        }
    }
}
