using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.CatLady
{
    public abstract class Cat
    {
        private string name;
        public Cat(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
    }
}
