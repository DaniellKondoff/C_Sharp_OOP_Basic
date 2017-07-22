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

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption+AirConsumption,tankCapacity)
        {
        }

        protected override double FuelQuantity
        {
            set
            {
                if (value /*+ this.FuelQuantity*/ > this.TankCapacity)
                {
                    throw new ArgumentException("Cannot fit fuel in tank");
                }
                base.FuelQuantity = value;
            }
        }
    }
}
