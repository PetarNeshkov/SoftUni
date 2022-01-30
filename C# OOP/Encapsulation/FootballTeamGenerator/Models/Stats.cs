﻿using FootballTeamGenerator.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator.Models
{
   public class Stats
    {
        private const int MIN_STAT = 0;
        private const int MAX_STAT = 100;
        private const double STAT_CNT = 5; 
        //double e за да не направи целочислено делене

        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public int Endurance
        {
            get => endurance;
            private set
            {
                ValidateStat(nameof(Endurance), value);
                endurance = value;
            }
        }
        public int Sprint
        {
            get => sprint;
            private set
            {
                ValidateStat(nameof(Sprint), value);
                sprint = value;
            }
        }
        public int Dribble
        {
            get => dribble;
            private set
            {
                ValidateStat(nameof(Dribble), value);
                dribble = value;
            }
        }
        public int Passing
        {
            get => passing;
            private set
            {
                ValidateStat(nameof(Passing), value);
                passing = value;
            }
        }
        public int Shooting
        {
            get => shooting;
            private set
            {
                ValidateStat(nameof(Shooting), value);
                shooting = value;
            }
        }
        public double AverageStat => (Endurance + Shooting + Sprint + Dribble + Passing) / STAT_CNT;
        private void ValidateStat(string name,int value)
        {
            if (value < MIN_STAT || value > MAX_STAT)
            {
                throw new ArgumentException
                    (String.Format
                    (GlobalConstants.InvalidStatExcMsg,name, MIN_STAT, MAX_STAT));
            }
        }
    }
}
