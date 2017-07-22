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
        private double tankCapacity;
        public Vehicle(double fuelQuantity,double fuelConsumption,double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }
                this.fuelQuantity = value;
            }
        }
        public double FuelConsumptionPerKm { get { return this.fuelConsumptionPerKm; } set { this.fuelConsumptionPerKm = value; } }

        public double TankCapacity
        {
            get { return this.tankCapacity; }
            set
            {
                this.tankCapacity = value;
            }
        }
        public abstract void Drive(double distance);

        public virtual void Refuel(double litres)
        {
            if (litres <=0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            this.FuelQuantity += litres;
        }

    }
}
