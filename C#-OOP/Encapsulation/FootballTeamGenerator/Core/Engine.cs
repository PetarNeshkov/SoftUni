using FootballTeamGenerator.Common;
using FootballTeamGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator.Core
{
    public class Engine
    {
        //private readonly ICollection<Team> teams;
        //public Engine()
        //{
        //    teams = new List<Team>();
        //}
        //public void Run()
        //{
        //    string command;
        //    while ((command = Console.ReadLine()) != "END")
        //    {
        //        string[] cmdArgs = command.Split(";");

        //        string cmdType = cmdArgs[0];
        //        try
        //        {
        //            List<string> cmdParams = cmdArgs.Skip(1).ToList();
        //            if (cmdType == "Team")
        //            {
        //                CreateTeam(cmdParams);
        //            }
        //            else if (cmdType == "Add")
        //            {
        //                AddPlayerToTeam(cmdParams);
        //            }
        //            else if (cmdType == "Remove")
        //            {
        //                RemovePlayerFromTeam(cmdParams);
        //            }
        //            else if (cmdType == "Rating")
        //            {
        //                RateTeam(cmdParams);
        //            }
        //        }
        //        catch (ArgumentException ae)
        //        {

        //            Console.WriteLine(ae.Message);

        //        }
        //        catch (InvalidOperationException ioe)
        //        {
        //            Console.WriteLine(ioe.Message);
        //        }
        //    }
        //}
        //private void CreateTeam(IList<string> cmdArgs)
        //{
        //    string teamName = cmdArgs[0];

        //    Team team = new Team(teamName);
        //    teams.Add(team);
        //}
        //private void AddPlayerToTeam(IList<string> cmdArgs)
        //{
        //    string teamName = cmdArgs[0];
        //    string playerName = cmdArgs[1];

        //    ValidateTeamExists(teamName);
        //    Stats stats = BuildStats(cmdArgs.Skip(2).ToArray());

        //    Player player = new Player(playerName, stats);

        //    Team team = teams.First(team => team.Name == teamName);
        //    team.AddPlayer(player);
        //}
        //public void RemovePlayerFromTeam(IList<string> cmdArs)
        //{
        //    string teamName = cmdArs[0];
        //    string playerName = cmdArs[1];

        //    ValidateTeamExists(teamName);

        //    Team team = teams.First(team => team.Name == teamName);
        //    team.RemovePlayer(playerName);
        //}
        //private void RateTeam(IList<string> cmdArgs)
        //{
        //    string teamName = cmdArgs[0];

        //    ValidateTeamExists(teamName);
        //    Team team = teams.First(team => team.Name == teamName);

        //    Console.WriteLine(team);
        //}
        //private Stats BuildStats(string[] statsString)
        //{
        //    int endurance = int.Parse(statsString[0]);
        //    int sprint = int.Parse(statsString[1]);
        //    int dribble = int.Parse(statsString[2]);
        //    int passing = int.Parse(statsString[3]);
        //    int shooting = int.Parse(statsString[4]);

        //    Stats stats = new Stats(endurance, sprint, dribble, passing, shooting);
        //    return stats;
        //}
        //private void ValidateTeamExists(string teamName)
        //{
        //    if (!teams.Any(t => t.Name == teamName))
        //    {
        //        throw new InvalidOperationException
        //            (String.Format(GlobalConstants.MissingTeamExcMsg, teamName));
        //    }
        //}
        private readonly ICollection<Team> teams;

        public Engine()
        {
            teams = new List<Team>();
        }

        public void Run()
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(";");
                try
                {
                    string command = tokens[0];
                    List<string> cmdParams = tokens.Skip(1).ToList();
                    if (command == "Team")
                    {
                        CreateTeam(cmdParams);
                    }
                    else if (command == "Add")
                    {

                    }
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }
        }
        private void CreateTeam(IList<string> cmdArgs)
        {
            string teamName = cmdArgs[0];
            ValidateTeamExist(teamName);
            Team team = new Team(teamName);
            teams.Add(team);
        }
        private void AddPlayerToTheTeam(IList<string> cmdArgs)
        {
            string teamName = cmdArgs[0];
            ValidateTeamExist(teamName);
            string playerName = cmdArgs[1];
            BuildStats(cmdArgs.Skip(2).ToList());
        }
        private Stats BuildStats(IList<string> cmdArgs)
        {
            int endurance = int.Parse(cmdArgs[0]);
            int sprint = int.Parse(cmdArgs[1]);
            int dribble = int.Parse(cmdArgs[2]);
            int passing = int.Parse(cmdArgs[3]);
            int shooting = int.Parse(cmdArgs[4]);

        }
        private void ValidateTeamExist(string teamName)
        {
            if (!teams.Any(team => team.Name == teamName))
            {
                throw new
                    ArgumentException(
                    String.Format(GlobalConstants.MissingTeamExcMsg, teamName));
            }
        }
    }
}
