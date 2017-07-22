using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vechles.Models
{
    public class Car : Vechicle
    {
        private const double AirConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption+AirConsumption)
        {
        }
    }
}
