using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.WildFarm.Foods;

namespace _3.WildFarm.Animals
{
    public class Tiger : Felime
    {
        public Tiger(string animalType, string animalName, double animalWight, string livingRegion)
            : base(animalType, animalName, animalWight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Meat")
            {
                throw new ArgumentException($"Tigers are not eating that type of food!");
            }

            base.Eat(food);

        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }
    }
}
