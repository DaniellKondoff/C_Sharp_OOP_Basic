using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vechles.Models
{
    public abstract class Vechicle
    {
        public Vechicle(double fuelQuantity, double fuelConsumption,double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumption;
        }

        protected virtual double FuelQuantity { get; set; }
        protected double FuelConsumptionPerKm { get; set; }
        protected double TankCapacity { get; set; }
        protected virtual bool Drive(double distance,bool isAcON)
        {
            var fuelRequired = distance * this.FuelConsumptionPerKm;
            if (fuelRequired <= this.FuelQuantity)
            {
                this.FuelQuantity -= fuelRequired;
                return true;
            }
            return false;
        }

        public string TryDrive(double distance, bool isAcOn)
        {
            if (this.Drive(distance,isAcOn))
            {
                return $"{this.GetType().Name} travelled {distance} km";
            }
            return $"{this.GetType().Name} needs refueling";
        }

        public string TryDrive(double distance)
        {
            return this.TryDrive(distance, true);
        }


        public virtual void Refuel(double liters)
        {
            if (liters <=0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            this.FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
