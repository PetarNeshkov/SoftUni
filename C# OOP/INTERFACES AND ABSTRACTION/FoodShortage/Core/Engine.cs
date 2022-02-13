using FoodShortage.Contracts;
using FoodShortage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodShortage.Core
{
    public class Engine
    {
        private readonly ICollection<IBuyer> buyers;
        public Engine()
        {
            buyers = new List<IBuyer>();
        }
        public void Run()
        {
            int counter = int.Parse(Console.ReadLine());
            for (int i = 0; i < counter; i++)
            {
                string[] split = Console.ReadLine().Split();
                if (split.Length == 3)
                {
                    GetRebel(split);
                }
                else if (split.Length == 4)
                {
                    GetCitizen(split);
                }
            }
            string name;
            while ((name=Console.ReadLine())!="End")
            {
                IBuyer check = buyers.FirstOrDefault(x => x.Name == name);
                if (check!=null)
                {
                    check.BuyFood();
                }
            }
            int TotalFood = buyers.Sum(x => x.Food);
            Console.WriteLine(TotalFood);
        }
        private void GetCitizen(string[] split)
        {
            string CitizenName = split[0];
            int Age = int.Parse(split[1]);
            string Id = split[2];
            string BirthDate = split[3];
            IBuyer citizen = new Citizen(CitizenName, Age, Id, BirthDate);

            buyers.Add(citizen);
        }
        private void GetRebel(string[] split)
        {
            string RebelName = split[0];
            string Id = split[1];
            string Group = split[2];
            IBuyer rebel = new Rebel(RebelName, Id, Group);

            buyers.Add(rebel);
        }
    }
}
