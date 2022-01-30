using FootballTeamGenerator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator.Models
{
    public class Team
    {
        private string name;
        private readonly ICollection<Player> players;

        public Team()
        {
            players = new List<Player>();
        }
        public Team(string name) : this()
        {
            Name = name;
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
        public int Rating => players.Count>0 ? (int)Math.Round
            (players.Average(p => p.OverallSkill)) : 0;
        public void AddPlayer(Player player)
        {
            players.Add(player);
        }
        public void RemovePlayer(string playerName)
        {
            Player playerToRemove = players.FirstOrDefault(p => p.Name == playerName);
            if (playerToRemove==null)
            {
                throw new 
                    InvalidOperationException(
                    String.Format(GlobalConstants.MissingPlayerExcMsg,playerName,Name));
            }
            players.Remove(playerToRemove);
        }
        public override string ToString()
        {
            return $"{Name} - {Rating}";
        }
    }
}
