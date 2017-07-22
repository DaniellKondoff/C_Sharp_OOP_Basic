using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Vehicles
{
    public class Bus : Vehicle
    {
        private const double AirCondition = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            double fuelConsumption = this.FuelConsumptionPerKm + AirCondition;
            double travellDistance = distance * fuelConsumption;

            if (travellDistance <= this.FuelQuantity)
            {
                double tempQuantity = this.FuelQuantity - travellDistance;
                this.FuelQuantity = tempQuantity;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }

        public void DriveEmpty(double distance)
        {       
            double travellDistance = distance * this.FuelConsumptionPerKm;

            if (travellDistance <= this.FuelQuantity)
            {
                double tempQuantity = this.FuelQuantity - travellDistance;
                this.FuelQuantity = tempQuantity;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }

        public override void Refuel(double litres)
        {
            if (litres <=0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            if ((this.FuelQuantity + litres) > this.TankCapacity)
            {
                Console.WriteLine("Cannot fit fuel in tank");
            }
            else
            {
                double fuel = this.FuelQuantity + litres;
                this.FuelQuantity = fuel;
            }
        }
    }
}
