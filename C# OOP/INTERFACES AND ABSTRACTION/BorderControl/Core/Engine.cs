
using BorderControl.Interfaces;
using BorderControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl.Core
{
   public class Engine
    {
        private ICollection<IIdentifiable> identifiables;
        public Engine()
        {
            identifiables = new List<IIdentifiable>();
        }
        public void Run()
        {
            string input;
            while ((input=Console.ReadLine())!="End")
            {
                string[] split = input.Split();
                if (split.Length == 2)
                {
                    AddRobot(split);
                }
                else if (split.Length == 3)
                {
                    AddCitisen(split);
                }
            }
            string fakeId=Console.ReadLine();
             identifiables.Where(x => x.Id.EndsWith(fakeId))
                .ToList().ForEach(x => { Console.WriteLine(x.Id);});
        }

        private void AddCitisen(string[] split)
        {
            string name = split[0];
            int age = int.Parse(split[1]);
            string id = split[2];
            IIdentifiable human = new Citizen(name,age,id);
            identifiables.Add(human);
        }

        private void AddRobot(string[] split)
        {
            string model = split[0];
            string id = split[1];
            IIdentifiable robot = new Robot(id, model);
            identifiables.Add(robot);
        }
    }
}
