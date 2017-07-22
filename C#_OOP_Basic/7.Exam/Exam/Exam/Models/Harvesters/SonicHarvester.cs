using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SonicHarvester : Harvester
{
    private int sonicFactor;

    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor) 
        : base(id, oreOutput, energyRequirement)
    {
        this.SonicFactor = sonicFactor;
        this.EnergyRequirement /= this.SonicFactor;
    }

    public int SonicFactor
    {
        get { return this.sonicFactor ; }
        private set { this.sonicFactor  = value; }
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

