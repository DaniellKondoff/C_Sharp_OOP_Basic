using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Google
{
    public class Child
    {
        public Child(string name,string birthDay)
        {
            this.Name = name;
            this.BirthDay = birthDay;
        }
        public string Name { get; set; }
        public string BirthDay { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.BirthDay}";
        }
    }
}
