using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Garage
{
    public Garage()
    {
        this.ParkedCars = new List<Car>();
    }
    public ICollection<Car> ParkedCars { get; set; }

    public override string ToString()
    {
        return base.ToString();
    }
}

