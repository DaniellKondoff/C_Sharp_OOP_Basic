using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Vehicles
{
    public class Car : Vehicle
    {
        private const double AirCondition = 0.9;

        public Car(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption)
        {
        }


        public override void Drive(double distance)
        {
            double fuelConsumption = this.FuelConsumptionPerKm + AirCondition;
            double travellDistance = distance * fuelConsumption;

            if (travellDistance <= this.FuelQuantity)
            {
                double tempQuantity = this.FuelQuantity = travellDistance;
                this.FuelQuantity = tempQuantity;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }
       
    }
}
