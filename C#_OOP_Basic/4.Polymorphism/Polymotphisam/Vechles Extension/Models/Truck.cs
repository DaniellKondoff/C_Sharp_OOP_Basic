using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vechles.Models
{
    public class Truck : Vechicle
    {
        private const double AirConsumption = 1.6;
        private const double FuelLossFactor = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity,fuelConsumption + AirConsumption,tankCapacity)
        {

        }

        public override void Refuel(double liters)
        {
            base.Refuel(liters*FuelLossFactor);
        }
    }
}
