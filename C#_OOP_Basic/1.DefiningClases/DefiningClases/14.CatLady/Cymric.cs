using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.CatLady
{
    public class Cymric : Cat
    {
        private decimal furLenght;
        public Cymric(string name,decimal furLenght) 
            : base(name)
        {
            this.FurLenght = furLenght;
        }

        public decimal FurLenght
        {
            get
            {
                return this.furLenght;
            }
            set
            {
                this.furLenght = value;
            }
        }

        public override string ToString()
        {
            return $"Cymric {this.Name} {this.FurLenght:f2}";
        }
    }
}
