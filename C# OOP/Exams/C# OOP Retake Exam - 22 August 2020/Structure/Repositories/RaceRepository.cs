﻿using EasterRaces.Models.Races.Contracts;
using EasterRaces.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace EasterRaces.Repositories
{
    public class RaceRepository : IRepository<IRace>
    {
        private readonly List<IRace> races;
        public RaceRepository()
        {
            races = new List<IRace>();
        }
        public void Add(IRace model)
         => races.Add(model);

        public IReadOnlyCollection<IRace> GetAll()
        => races.ToArray();

        public IRace GetByName(string name)
        => races.FirstOrDefault(x => x.Name == name);

        public bool Remove(IRace model)
        => races.Remove(model);
    }
}
