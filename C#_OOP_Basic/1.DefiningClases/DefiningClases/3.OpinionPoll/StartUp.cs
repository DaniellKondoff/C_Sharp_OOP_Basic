using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.OpinionPoll
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> personsList = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Person person = new Person(inputLine[0], int.Parse(inputLine[1]));
                personsList.Add(person);
            }

            foreach (var person in personsList.Where(p=>p.Age>30).OrderBy(p=>p.Name).ToList())
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
