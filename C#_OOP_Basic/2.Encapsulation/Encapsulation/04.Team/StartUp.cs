using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



static class StartUp
{

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var team = new Team("Beroe");

        for (int i = 0; i < n; i++)
        {
            var inputLines = Console.ReadLine().Split();
            Person player = new Person(inputLines[0], inputLines[1], int.Parse(inputLines[2]), double.Parse(inputLines[3]));
            team.AddPlayer(player);
        }
    }
}

