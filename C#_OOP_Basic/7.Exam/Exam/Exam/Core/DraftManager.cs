using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private Dictionary<string, Harvester> harvestors;
    private Dictionary<string, Provider> providers;
    private double totalStoredEnergy;
    private double totalMinedOre;
    string mode;
    public DraftManager()
    {
        this.harvestors = new Dictionary<string, Harvester>();
        this.providers = new Dictionary<string, Provider>();
        this.totalStoredEnergy = 0;
        this.totalMinedOre = 0;
        this.mode = "Full";
    }
    public string RegisterHarvester(List<string> arguments)
    {
        string type = arguments[0];
        string id = arguments[1];
        try
        {
            Harvester newHarvester = this.MakeHarvester(arguments);
            harvestors.Add(id, newHarvester);
            return $"Successfully registered {type} Harvester - {id}";
        }
        catch (Exception e)
        {
            return e.Message;
        }
   
    }
    public string RegisterProvider(List<string> arguments)
    {
        string type = arguments[0];
        string id = arguments[1];
        double energyOutput = double.Parse(arguments[2]);

        try
        {
            Provider newProvider = this.MakeProvider(arguments);
            providers.Add(id, newProvider);
            return $"Successfully registered {type} Provider - {id}";
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }
    public string Day()
    {
        double currentMineOre = 0;
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("A day has passed.");
        totalStoredEnergy += this.providers.Values.Sum(v => v.EnergyOutput);

        var harvesterCurrentEnergy = this.harvestors.Values.Sum(v => v.EnergyRequirement);

        if (this.mode == "Half")
        {
            harvesterCurrentEnergy *= 0.6;
        }
        else if (this.mode == "Energy")
        {
            harvesterCurrentEnergy = 0;
        }
        sb.AppendLine($"Energy Provided: {this.providers.Values.Sum(v => v.EnergyOutput)}");

        if (totalStoredEnergy >= harvesterCurrentEnergy)
        {
            totalStoredEnergy -= harvesterCurrentEnergy;
            currentMineOre = this.harvestors.Values.Sum(v => v.OreOutput);
            if (this.mode=="Half")
            {
                currentMineOre *= 0.5;
            }
            else if (this.mode == "Energy")
            {
                currentMineOre = 0;
            }
            totalMinedOre += currentMineOre;
        }
        sb.AppendLine($"Plumbus Ore Mined: {currentMineOre}");
        return sb.ToString().Trim();
    }
    public string Mode(List<string> arguments)
    {
        this.mode = arguments[0];
        return $"Successfully changed working mode to {mode} Mode";
    }
    public string Check(List<string> arguments)
    {
        string idToCheck = arguments[0];
        int harvesterCount = this.harvestors.Count(k => k.Key == idToCheck);
        if (harvesterCount >0)
        {
            return harvestors[idToCheck].ToString();
        }
        int providersCount = this.providers.Count(k => k.Key == idToCheck);
        if (providersCount > 0)
        {
            return providers[idToCheck].ToString();
        }
        else
        {
            return $"No element found with id - {idToCheck}";
        }
    }
    public string ShutDown()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {this.totalStoredEnergy}");
        sb.AppendLine($"Total Mined Plumbus Ore: {this.totalMinedOre}");
        return sb.ToString().Trim();
    }

    private Harvester MakeHarvester(List<string> arguments)
    {
        Harvester harvester = null;
        string type = arguments[0];
        string id = arguments[1];
        double oreOutput = double.Parse(arguments[2]);
        double energyRequirement = double.Parse(arguments[3]);

        if (type == "Hammer")
        {
            harvester = HarvesterFactory.MakeHammerHarvester(id, oreOutput, energyRequirement);
        }
        else
        {
            int sonicFactor = int.Parse(arguments[4]);
            harvester = HarvesterFactory.MakeSonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
        }
        return harvester;
    }

    private Provider MakeProvider(List<string> arguments)
    {
        Provider provider = null;
        string type = arguments[0];
        string id = arguments[1];
        double energyOutput = double.Parse(arguments[2]);
        if (type == "Solar")
        {
             provider = ProviderFactory.MakeSolarProvider(id, energyOutput);
            
        }
        else
        {
             provider = ProviderFactory.MakePressureProvider(id, energyOutput);       
        }
        return provider;
    }
}

