using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private double overallSkill;

        public Player(string name, Stat endurance, Stat sprint, Stat dribble, Stat passing, Stat shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;

            this.CalculateAverageStats();
        }

        private void CalculateAverageStats()
        {
            double sum = (this.Endurance.Level + this.Sprint.Level + this.Dribble.Level + this.Passing.Level + this.Shooting.Level);
            this.overallSkill = Math.Round(sum / 5, 0);
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
        public Stat Endurance { get; private set; }
        public Stat Sprint { get; private set; }
        public Stat Dribble { get; private set; }
        public Stat Passing { get; private set; }
        public Stat Shooting { get; private set; }

        public double OverralSkill
        {
            get { return this.overallSkill; }
            private set { this.overallSkill = value; }
        }
    }
}
