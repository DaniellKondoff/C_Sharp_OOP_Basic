using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Google
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var people = new HashSet<Person>();

            while (input != "End")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var person = people.FirstOrDefault(p => p.Name == tokens[0]);
                if (person==null)
                {
                    person = new Person(tokens[0]);
                }

                if (tokens[1] == "company")
                {
                    var company = new Company(tokens[2], tokens[3], decimal.Parse(tokens[4]));
                    person.Company = company;
                }
                else if (tokens[1] == "pokemon")
                {
                    var pokemon = new Pokemon(tokens[2], tokens[3]);
                    person.Pokemons.Add(pokemon);
                }
                else if (tokens[1]== "parents")
                {
                    var parents = new Parent(tokens[2], tokens[3]);
                    person.Parents.Add(parents);
                }
                else if (tokens[1] == "children")
                {
                    var children = new Child(tokens[2], tokens[3]);
                    person.Children.Add(children);
                }
                else if (tokens[1]== "car")
                {
                    var car = new Car(tokens[2], tokens[3]);
                    person.Car = car;
                }

                people.Add(person);
                input = Console.ReadLine();
            }

            var targetPerson = Console.ReadLine();
            var personToPrint = people.FirstOrDefault(p => p.Name == targetPerson);

            Console.WriteLine(personToPrint.Name);
            Console.WriteLine("Company: {0}",personToPrint.Company==null ? "": $"\n{personToPrint.Company.ToString()}");
            Console.WriteLine("Car: {0}",personToPrint.Car==null ? "":$"\n{personToPrint.Car.ToString()}");
            Console.WriteLine("Pokemon:");

            if (personToPrint.Pokemons.Count != 0)
            {
                foreach (var pokemon in personToPrint.Pokemons)
                {
                    Console.WriteLine(pokemon.ToString());
                }
            }
            Console.WriteLine("Parents:");
            if (personToPrint.Parents.Count != 0)
            {
                foreach (var perants in personToPrint.Parents)
                {
                    Console.WriteLine(perants.ToString());
                }
            }
            Console.WriteLine("Children:");
            if (personToPrint.Children.Count != 0)
            {
                foreach (var child in personToPrint.Children)
                {
                    Console.WriteLine(child.ToString());
                }
            }
        }
    }
}
