using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> reserveTeam;

    public Team(string name)
    {
        this.Name = name;
        firstTeam = new List<Person>();
        reserveTeam = new List<Person>();
    }


    public string Name { get { return this.name; } private set { this.name = value; } }

    public IReadOnlyList<Person> FirstTeam
    {
        get
        {
            return this.firstTeam.AsReadOnly();
        }
        
    }

    public IReadOnlyList<Person> ReserveTeam
    {
        get
        {
            return this.reserveTeam.AsReadOnly();
        }

    }

    public void AddPlayer(Person player)
    {
        if (player.Age <40)
        {
            this.firstTeam.Add(player);
        }
        else
        {
            this.reserveTeam.Add(player);
        }
    }
}

