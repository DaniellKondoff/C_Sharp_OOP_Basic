using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ProviderFactory 
{
    private ProviderFactory()
    {

    }

    public static Provider MakePressureProvider(string id, double energyOutput)
    {
        return new PressureProvider(id, energyOutput);
    }

    public static Provider MakeSolarProvider(string id, double energyOutput)
    {
        return new SolarProvider(id, energyOutput);
    }
}

