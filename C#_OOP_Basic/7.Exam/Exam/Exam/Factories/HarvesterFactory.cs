using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class HarvesterFactory
{
    private HarvesterFactory()
    {

    }

    public static Harvester MakeHammerHarvester(string id, double oreOutput, double energyRequirement)
    {
        return new HammerHarvester(id, oreOutput, energyRequirement);
    }

    public static Harvester MakeSonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor)
    {
        return new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
    }
}

