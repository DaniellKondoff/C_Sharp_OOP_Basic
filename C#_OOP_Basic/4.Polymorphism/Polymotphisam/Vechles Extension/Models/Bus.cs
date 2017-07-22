using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vechles.Models
{
    public class Bus : Vechicle
    {
        private const double AirCondition = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
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

        protected override bool Drive(double distance, bool isAcON)
        {
            double requiredFuel = 0;
            if (isAcON)
            {
                requiredFuel = distance * (this.FuelConsumptionPerKm + AirCondition);
            }
            else
            {
                requiredFuel = distance * (this.FuelConsumptionPerKm);
            }

            if (requiredFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= requiredFuel;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
