using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vechles.Models
{
    public abstract class Vechicle
    {
        public Vechicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumption;
        }

        protected double FuelQuantity { get; set; }
        protected double FuelConsumptionPerKm { get; set; }
        private bool Drive(double distance)
        {
            var fuelRequired = distance * this.FuelConsumptionPerKm;
            if (fuelRequired <= this.FuelQuantity)
            {
                this.FuelQuantity -= fuelRequired;
                return true;
            }
            return false;
        }

        public string TryDrive(double distance)
        {
            if (this.Drive(distance))
            {
                return $"{this.GetType().Name} travelled {distance} km";
            }
            return $"{this.GetType().Name} needs refueling";
        }


        public virtual void Refuel(double liters)
        {
            this.FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
