using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        List<Player> roster;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => roster.Count;
        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            roster = new List<Player>();
        }
        public void AddPlayer(Player player)
        {
            if (roster.Count < Capacity)
            {
                roster.Add(player);
            }
        }
        public bool RemovePlayer(string name)
        {
            foreach (var person in roster)
            {
                if (person.Name == name)
                {
                    roster.Remove(person);
                    return true;
                }
            }
            return false;
        }
        public void PromotePlayer(string name)
        {
            Player myPromotedPlayer = roster.Where(x => x.Name == name).FirstOrDefault();
            myPromotedPlayer.Rank = "Member";
        }
        public void DemotePlayer(string name)
        {
            foreach (var person in roster)
            {
                Player myDemotedPlayer = roster.Where(x => x.Name == name).FirstOrDefault();
                myDemotedPlayer.Rank = "Trial";
            }
        }
        public Player[] KickPlayersByClass(string classToRemove)
        {
            Player[] playersToKick = roster.Where(x => x.Class == classToRemove).ToArray();
            roster = roster.Where(x => x.Class != classToRemove).ToList();
            return playersToKick;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");
            foreach (var player in roster)
            {
                sb.AppendLine($"{player}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
