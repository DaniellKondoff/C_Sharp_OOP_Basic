using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ShowCar : Car
{
    public ShowCar(string brand, string model, int year, int horsepower, int acceleration, int suspension, int durability)
        : base(brand, model, year, horsepower, acceleration, suspension, durability)
    {
        this.Stars = 0;
    }

    public int Stars { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder(base.ToString());
        sb.Append($"{this.Stars} *");
        return sb.ToString().Trim();
    }
}

