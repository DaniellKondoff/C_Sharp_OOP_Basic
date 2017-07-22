using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumptionPerKm;

        public Vehicle(double fuelQuantity,double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumption;
        }

        public double FuelQuantity { get { return this.fuelQuantity; } set { this.fuelQuantity = value; } }
        public double FuelConsumptionPerKm { get { return this.fuelConsumptionPerKm; } set { this.fuelConsumptionPerKm = value; } }

        public abstract void Drive(double distance);

        public virtual void Refuel(double litres)
        {
            this.FuelQuantity += litres;
        }

    }
}
