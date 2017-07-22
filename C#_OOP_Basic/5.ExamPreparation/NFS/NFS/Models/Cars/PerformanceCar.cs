using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class PerformanceCar : Car
{
    
    public PerformanceCar(string brand, string model, int year, int horsepower, int acceleration, int suspension, int durability) 
        : base(brand, model, year, horsepower, acceleration, suspension, durability)
    {
        this.AddOns = new List<string>();
        this.HorsePower += this.HorsePower * 50 / 100;
        this.Suspension -= this.Suspension * 25 / 100;
    }

    public ICollection<string> AddOns { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder(base.ToString());
        if (this.AddOns.Count == 0)
        {
            sb.AppendLine("Add-ons: None");
        }
        else
        {
            sb.AppendLine($"Add-ons: {string.Join(", ", this.AddOns)}");
        }
        return sb.ToString().Trim();
    }

    public override void Tune(int tuneIndex, string addon)
    {
        base.Tune(tuneIndex, addon);
        this.AddOns.Add(addon);
    }
}

