using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SppedRacing
{
    public class Car
    {

        public Car(string model,double fuelAmount,double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKm = fuelConsumption;
            this.DistanceTraveled = 0;
        }
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKm { get; set; }

        public double DistanceTraveled { get; set; }

        public void Drive (int distanceToTravel)
        {
            if (distanceToTravel <= (this.FuelAmount / this.FuelConsumptionPerKm))
            {
                this.DistanceTraveled += distanceToTravel;

                this.FuelAmount -= (distanceToTravel * this.FuelConsumptionPerKm);
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

    }
}
