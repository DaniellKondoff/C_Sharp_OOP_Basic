using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class CircuitRace : Race
{
    public CircuitRace(int length, string route, int prizePool,int laps) 
        : base(length, route, prizePool)
    {
        this.Laps = laps;
    }

    public int Laps { get; private set; }
    public override int GetPerformance(int id)
    {
        throw new NotImplementedException();
    }
}

