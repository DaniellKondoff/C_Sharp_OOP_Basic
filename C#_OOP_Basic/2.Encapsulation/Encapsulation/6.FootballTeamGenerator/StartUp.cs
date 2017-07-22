using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.FootballTeamGenerator
{
    class StartUp
    {
        static Dictionary<string, Team> teams = new Dictionary<string, Team>();

        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            
            while (inputLine != "END")
            {
                string[] tokens = inputLine.Split(';');
                var cmd = tokens[0];

                try
                {
                    ProcessCommand(tokens, cmd);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }

                inputLine = Console.ReadLine();
            }
        }

        private static void ProcessCommand(string[] tokens, string cmd)
        {
            switch (cmd)
            {
                case "Team":
                    CreateTeam(tokens[1]);
                    break;
                case "Add":
                    AddPlayerToTeam(tokens[1], tokens[2], int.Parse(tokens[3]), int.Parse(tokens[4]),
                        int.Parse(tokens[5]), int.Parse(tokens[6]), int.Parse(tokens[7]));
                    break;
                case "Remove":
                    RemovePlayerFromTeam(tokens[1], tokens[2]);
                    break;
                case "Rating":
                    PrintRating(tokens[1]);
                    break;
            }
        }

        private static void PrintRating(string teamName)
        {
            var team = teams[teamName];
            Console.WriteLine(team.ToString());
        }

        private static void RemovePlayerFromTeam(string teamName, string playerName)
        {
            if (!teams.ContainsKey(teamName))
            {
                throw new InvalidOperationException($"Team {teamName} does not exist.");
            }
            var team = teams[teamName];
            team.RemovePlayer(playerName);
        }

        private static void AddPlayerToTeam(string teamName, string playerName, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            if (!teams.ContainsKey(teamName))
            {
                throw new InvalidOperationException($"Team {teamName} does not exist.");
            }
            Player player = new Player(
                playerName,
                new Stat("Endurance", endurance),
                new Stat("Sprint", sprint),
                new Stat("Dribble", dribble),
                new Stat("Passing", passing),
                new Stat("Shooting", shooting)
                );
            var team = teams[teamName];
            team.AddPlayer(player);
        }

        private static void CreateTeam(string teamName)
        {
            Team team = new Team(teamName);
            teams.Add(teamName, team);
        }
    }
}
