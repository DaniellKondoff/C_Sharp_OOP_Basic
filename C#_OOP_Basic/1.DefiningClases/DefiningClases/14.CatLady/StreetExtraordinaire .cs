using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.CatLady
{
    public class StreetExtraordinaire : Cat
    {
        private int dicibels;
        public StreetExtraordinaire(string name,int dicibels) 
            : base(name)
        {
            this.Dicibels = dicibels;
        }
        public int Dicibels
        {
            get
            {
                return this.dicibels;
            }
            set
            {
                this.dicibels = value;
            }
        }

        public override string ToString()
        {
            return $"StreetExtraordinaire {this.Name} {this.Dicibels}";
        }
    }
}
