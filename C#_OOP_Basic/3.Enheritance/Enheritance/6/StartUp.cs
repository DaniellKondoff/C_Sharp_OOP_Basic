using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();

            var input = Console.ReadLine();


            while (input != "Beast!")
            {
                try
                {
                    string[] dataDog = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string name = dataDog[0];
                    int age;
                    if (!int.TryParse(dataDog[1], out age))
                    {
                        throw new ArgumentException("invalid input!");
                    }

                    string gender = dataDog[2];

                    switch (input)
                    {
                        case "Dog":
                            Animal dog = new Dog(name, age, gender);
                            animals.Add(dog);
                            break;
                        case "Cat":
                            Animal cat = new Cat(name, age, gender);
                            animals.Add(cat);
                            break;
                        case "Frog":
                            Animal frog = new Frog(name, age, gender);
                            animals.Add(frog);
                            break;
                        case "Kitten":
                            Animal kitten = new Kitten(name, age);
                            animals.Add(kitten);
                            break;
                        case "Tomcat":
                            Animal tomcat = new Tomcat(name, age);
                            animals.Add(tomcat);
                            break;
                        default:
                            throw new ArgumentException("Invalid input!");
                    }
                }
                catch (Exception ae)
                {

                    Console.WriteLine(ae.Message);
                }

                input = Console.ReadLine();
            }



            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine(animal.ToString());
                animal.ProduceSound();
            }
        }
    }
}
