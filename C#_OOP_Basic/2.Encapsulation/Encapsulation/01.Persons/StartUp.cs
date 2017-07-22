using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Person> people = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            var inputLines = Console.ReadLine().Split();
            Person person = new Person(inputLines[0], inputLines[1], int.Parse(inputLines[2]));
            people.Add(person);
        }

        people.OrderBy(p => p.FirstName)
            .ThenBy(p => p.Age)
            .ToList()
            .ForEach(p => Console.WriteLine(p.ToString()));
    }
}

