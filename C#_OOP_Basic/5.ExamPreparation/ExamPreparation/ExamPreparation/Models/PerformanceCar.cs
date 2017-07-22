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
    }

    public ICollection<string> AddOns { get; set; }

    public override int HorsePower
    {
        set
        {
            base.HorsePower = value + (value*50)/100;
        }
    }
    public override int Suspension
    {
        set
        {
            base.Suspension = value - (value * 25)/100;
        }
    }

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
}

