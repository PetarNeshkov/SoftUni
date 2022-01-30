using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public class Hero
    {

        public string Username { get; set; }
        public int level { get; set; }
        public Hero(string username, int level)
        {
            Username = username;
            this.level = level;
        }
        public override string ToString()
        {
            return $"Type: {GetType().Name} Username: {Username} Level: {level}";
        }
    }
}
