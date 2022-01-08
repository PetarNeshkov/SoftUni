using System;
using System.Collections.Generic;
using System.Text;
using FootballTeamGenerator.Common;
namespace FootballTeamGenerator.Models
{
    public class Player
    {
        private string name;
        public Player(string name,Stats stats)
        {
            Name = name;
            Stats = stats;
        }
        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidNameExcMsg);
                }
                name = value;
            }
        }
        public Stats Stats { get; set; }
        public double OverallSkill => Stats.AverageStat;

    }
}
