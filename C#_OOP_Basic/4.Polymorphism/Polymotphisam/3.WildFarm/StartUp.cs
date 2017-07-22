using _3.WildFarm.Animals;
using _3.WildFarm.Foods;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.WildFarm
{
    class StartUp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] animalInfo = Console.ReadLine().Split(new[] { '\t', ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                if (animalInfo[0] == "End")
                {
                    break;
                }

                string[] foodInfo = Console.ReadLine().Split(new[] { '\t', ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                Animal animal = null;
                Food food = null;

                switch (foodInfo[0].ToLower())
                {
                    case "vegetable":
                        food = new Vegetable(int.Parse(foodInfo[1]));
                        break;
                    case "meat":
                        food = new Meat(int.Parse(foodInfo[1]));
                        break;
                }

                string animalType = animalInfo[0];
                string animalName = animalInfo[1];
                double animalWeight = double.Parse(animalInfo[2]);
                string livingRegion = animalInfo[3];

                switch (animalType.ToLower())
                {
                    case "tiger":
                        animal = new Tiger(animalType, animalName, animalWeight, livingRegion);
                        break;
                    case "zebra":
                        animal = new Zebra(animalType, animalName, animalWeight, livingRegion);
                        break;
                    case "mouse":
                        animal = new Mouse(animalType, animalName, animalWeight, livingRegion);
                        break;
                    case "cat":
                        string breed = animalInfo[4];
                        animal = new Cat(animalType, animalName, animalWeight, livingRegion, breed);
                        break;
                }

                animal.MakeSound();
                try
                {
                    animal.Eat(food);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine(animal);
            }
        }
    }
}
