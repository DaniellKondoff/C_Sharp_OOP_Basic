using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.WildFarm.Foods;

namespace _3.WildFarm.Animals
{
    public class Cat : Felime
    {
        public Cat(string animalType, string animalName, double animalWight, string livingRegion,string breed) 
            : base(animalType, animalName, animalWight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get; set; }
       

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}[{this.AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FootEaten}]";
        }
    }
}
