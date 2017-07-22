using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Nation
{
    private List<Bender> benders;
    private List<Monument> monuments;

    public Nation()
    {
        this.benders = new List<Bender>();
        this.monuments = new List<Monument>();
    }

    public double GetTotalPower()
    {
        int momumentIncreasePercentage = this.monuments.Sum(m => m.GetAffinity());
        int totalBendersPower = this.benders.Sum(b => b.Power);
        int totalPowerIncrease = totalBendersPower / 100 * momumentIncreasePercentage;

        return totalBendersPower + totalPowerIncrease;
    }

    internal void AddBender(Bender currentBender)
    {
        this.benders.Add(currentBender);
    }

    internal void AddMonument(Monument monument)
    {
        this.monuments.Add(monument);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        if (benders.Count > 0)
        {
            sb.AppendLine($"Benders:");
            sb.AppendLine(string.Join(Environment.NewLine, benders));
        }
        else
        {
            sb.AppendLine("Benders: None");
        }

        if (monuments.Count > 0)
        {
            sb.AppendLine($"Monuments:");
            sb.AppendLine(string.Join(Environment.NewLine, monuments));
        }
        else
        {
            sb.AppendLine("Monuments: None");
        }
        return sb.ToString().Trim();
    }

    internal void KillYourSelf()
    {
        this.benders.Clear();
        this.monuments.Clear();
    }
}