using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Harvester
{
    private string id;
    private double oreOutput;
    private double energyRequirement;


    protected Harvester(string id,double oreOutput,double energyRequirement)
    {
        this.Id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }


    public string Id
    {
        get { return this.id; }
        private set { this.id = value; }
    }

    public double OreOutput
    {
        get
        {
            return this.oreOutput;
        }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {nameof(this.OreOutput)}");
            }
            this.oreOutput = value;
        }
    }

    public double EnergyRequirement
    {
        get
        {
            return this.energyRequirement;
        }
        protected set
        {
            if (value < 0 || value > 20000)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {nameof(this.EnergyRequirement)}");
            }
            this.energyRequirement = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Ore Output: {this.OreOutput}");
        sb.AppendLine($"Energy Requirement: {this.EnergyRequirement}");
        return sb.ToString().Trim();
    }
}

