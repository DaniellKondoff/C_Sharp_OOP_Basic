using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private double rating;
        private Dictionary<string,Player> players;

        public Team(string name)
        {
            this.players = new Dictionary<string, Player>();
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"A {nameof(this.name)} should not be empty.");
                }
                this.name = value;
            }
        }

        public void AddPlayer(Player player)
        {
            this.rating += player.OverralSkill;
            this.players.Add(player.Name, player);
        }

        public void RemovePlayer(string playerName)
        {
            if (!this.players.ContainsKey(playerName))
            {
                throw new InvalidOperationException($"Player {playerName} is not in {this.Name} team.");
            }

            Player player = this.players[playerName];
            this.players.Remove(player.Name);
            this.rating -= player.OverralSkill;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.rating}";
        }

    }
}
