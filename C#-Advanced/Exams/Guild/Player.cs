﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {

        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank { get; set; }
        public string Description { get; set; }
        public Player(string name, string currClass)
        {
            Name = name;
            Class = currClass;
            Rank = "Trial";
            Description = "n/a";
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Player {Name}: {Class}");
            sb.AppendLine($"Rank: {Rank}");
            sb.AppendLine($"Description: {Description}");
            return sb.ToString().TrimEnd();
        }
    }
}
