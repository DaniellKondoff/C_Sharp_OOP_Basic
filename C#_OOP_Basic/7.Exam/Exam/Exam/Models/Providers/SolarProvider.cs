using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SolarProvider : Provider
{
    public SolarProvider(string id, double energyOutput) 
        : base(id, energyOutput)
    {
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        string type = this.GetType().Name;
        int index = type.IndexOf("Provider");
        type = type.Insert(index, " ");
        sb.AppendLine($"{type} - {this.Id}");
        sb.Append(base.ToString());
        return sb.ToString().Trim();
    }
}

