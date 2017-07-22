using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Google
{
    public class Person
    {

        public Person(string name)
        {
            this.Name = name;
            this.Pokemons = new List<Pokemon>();
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
        }
        public string Name { get; set; }
        public Company Company { get; set; }
        public Car Car { get; set; }
        public ICollection<Pokemon> Pokemons { get; set; }
        public ICollection<Parent> Parents { get; set; }
        public ICollection<Child> Children { get; set; }
    }
}
