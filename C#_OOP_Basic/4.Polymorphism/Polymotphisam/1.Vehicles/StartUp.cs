using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Vehicles
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            var truckInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            var vechles = new List<Vehicle>();
            vechles.Add(car);
            vechles.Add(truck);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (tokens[0] == "Drive")
                {
                    if (tokens[1]=="Car")
                    {
                        car.Drive(double.Parse(tokens[2]));
                    }
                    else
                    {
                        truck.Drive(double.Parse(tokens[2]));
                    }
                }
                else
                {
                    if (tokens[1] == "Car")
                    {
                        car.Refuel(double.Parse(tokens[2]));
                    }
                    else
                    {
                        truck.Refuel(double.Parse(tokens[2]));
                    }
                }
            }

            foreach (var vechle in vechles)
            {
                Console.WriteLine($"{vechle.GetType().Name}: {vechle.FuelQuantity:f2}");
            }

        }
    }
}
