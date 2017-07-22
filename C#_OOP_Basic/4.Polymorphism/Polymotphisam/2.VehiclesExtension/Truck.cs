using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Vehicles
{
    public class Truck : Vehicle
    {
        private const double AirCondition = 1.6;
        private const double TankHole = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            double fuelConsumption = this.FuelConsumptionPerKm + AirCondition;
            double travelDistance = distance * fuelConsumption;

            if (travelDistance <= this.FuelQuantity)
            {
                double tempQuantity = this.FuelQuantity - travelDistance;
                this.FuelQuantity = tempQuantity;
                Console.WriteLine("Truck travelled {0} km", distance);
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }

        public override void Refuel(double litres)
        {
            
            base.Refuel(litres - (litres * 0.05));
        }
    }
}
