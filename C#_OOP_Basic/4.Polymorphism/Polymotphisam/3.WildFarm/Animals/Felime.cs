using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.WildFarm.Animals
{
    public abstract class Felime : Mammal
    {
        public Felime(string animalType, string animalName, double animalWight, string livingRegion) 
            : base(animalType, animalName, animalWight, livingRegion)
        {
        }
    }
}
