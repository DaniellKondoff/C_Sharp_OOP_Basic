using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private Dictionary<string, Nation> nations;
    private List<string> wars;

    public NationsBuilder()
    {
        this.nations = new Dictionary<string, Nation>()
        {
            {"Air",new Nation() },
            {"Fire",new Nation() },
            {"Earth",new Nation() },
            {"Water",new Nation() },
        };
        this.wars = new List<string>();
    }

    public void AssignBender(List<string> benderArgs)
    {
        var benderType = benderArgs[0];
        Bender currentBender = this.GetBender(benderArgs);
        this.nations[benderType].AddBender(currentBender);
    }

    private Bender GetBender(List<string> benderArgs)
    {
        var benderType = benderArgs[0];
        var benderName = benderArgs[1];
        var benderPower = int.Parse(benderArgs[2]);
        var benderAuxParam = double.Parse(benderArgs[3]);

        switch (benderType)
        {
            case "Air":
                return new AirBender(benderName, benderPower, benderAuxParam);

            case "Water":
                return new WaterBender(benderName, benderPower, benderAuxParam);

            case "Fire":
                return new FireBender(benderName, benderPower, benderAuxParam);

            case "Earth":
                return new EarthBender(benderName, benderPower, benderAuxParam);

            default:
                throw new ArgumentException();
        }
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        var monumentType = monumentArgs[0];
        Monument currentMonument = this.GetMonument(monumentArgs);
        this.nations[monumentType].AddMonument(currentMonument);
    }

    private Monument GetMonument(List<string> monumentArgs)
    {
        var monumentType = monumentArgs[0];
        var monumentName = monumentArgs[1];
        var monumentPower = int.Parse(monumentArgs[2]);

        switch (monumentType)
        {
            case "Air":
                return new AirMonument(monumentName, monumentPower);

            case "Water":
                return new WaterMonument(monumentName, monumentPower);

            case "Fire":
                return new FireMonument(monumentName, monumentPower);

            case "Earth":
                return new EarthMonument(monumentName, monumentPower);

            default:
                throw new ArgumentException();
        }
    }

    public string GetStatus(string nationsType)
    {
        return $"{nationsType} Nation" + Environment.NewLine + this.nations[nationsType].ToString();
    }

    public void IssueWar(string nationsType)
    {
        this.wars.Add(nationsType);
        var winner = nations.Max(n => n.Value.GetTotalPower());
        foreach (var nation in nations)
        {
            if (nation.Value.GetTotalPower() != winner)
            {
                nation.Value.KillYourSelf();
            }
        }
    }

    public string GetWarsRecord()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < this.wars.Count; i++)
        {
            sb.AppendLine($"War {i + 1} issued by {this.wars[i]}");
        }
        return sb.ToString().Trim();
    }
}