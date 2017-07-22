using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.WildFarm.Animals
{
    public abstract class Mammal : Animal
    {
        public Mammal(string animalType, string animalName, double animalWight,string livingRegion) 
            : base(animalType, animalName, animalWight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FootEaten}]";
        }
    }
}
