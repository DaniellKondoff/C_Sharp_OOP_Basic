using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class TimeLimitRace : Race
{
    public TimeLimitRace(int length, string route, int prizePool,int goldTime) 
        : base(length, route, prizePool)
    {
        this.GoldTime = goldTime;
    }

    public int GoldTime { get; private set; }
    public override int GetPerformance(int id)
    {
        var car = this.Participants[id];
        int tp = this.Length * ((car.HorsePower / 100) * car.Acceleration);
        return tp;
    }

    public override string StartRace()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.Route} - {this.Length}");
        return sb.ToString().Trim();
    }
}

