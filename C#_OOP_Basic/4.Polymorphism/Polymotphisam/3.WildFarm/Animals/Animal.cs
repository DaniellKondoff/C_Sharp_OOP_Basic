using _3.WildFarm.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.WildFarm.Animals
{
    public abstract class Animal
    {

        public Animal(string animalType,string animalName,double animalWight)
        {
            this.AnimalType = animalType;
            this.AnimalName = animalName;
            this.AnimalWeight = animalWight;
        }

        public string AnimalName { get; set; }
        public string AnimalType { get; set; }
        public double AnimalWeight { get; set; }
        public int FootEaten { get; set; }

        public abstract void MakeSound();
        public virtual void Eat(Food food)
        {
            this.FootEaten += food.Quantity;
        }

        
    }
}
