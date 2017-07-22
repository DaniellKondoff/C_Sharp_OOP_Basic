using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement) 
        : base(id, oreOutput, energyRequirement)
    {
        this.OreOutput += this.OreOutput * 200 / 100;
        this.EnergyRequirement += this.EnergyRequirement * 100 / 100;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        string type = this.GetType().Name;
        int index = type.IndexOf("Harvester");
        type = type.Insert(index, " ");
        sb.AppendLine($"{type} - {this.Id}");
        sb.Append(base.ToString());
        return sb.ToString().Trim();
    }
}

