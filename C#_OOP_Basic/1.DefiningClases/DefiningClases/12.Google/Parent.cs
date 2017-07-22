using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Google
{
    public class Parent
    {

        public Parent(string name, string birthday)
        {
            this.Name = name;
            this.BirthDay = birthday;
        }
        public string Name { get; set; }
        public string BirthDay { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.BirthDay}";
        }
    }
}
