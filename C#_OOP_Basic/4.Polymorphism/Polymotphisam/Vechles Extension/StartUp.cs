using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vechles.Models;

namespace Vechles
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var carInfo = Console.ReadLine().Split().ToArray();
            Vechicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));

            var truckInfo = Console.ReadLine().Split().ToArray();
            Vechicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));

            var busInfo = Console.ReadLine().Split().ToArray();
            Vechicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));


            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                try
                {
                    var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var vehicleType = tokens[1];

                    if (vehicleType == "Car")
                    {
                        ExecuteAction(car, tokens[0], double.Parse(tokens[2]));
                    }
                    else if (vehicleType == "Truck")
                    {
                        ExecuteAction(truck, tokens[0], double.Parse(tokens[2]));
                    }
                    else
                    {
                        ExecuteAction(bus, tokens[0], double.Parse(tokens[2]));
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);

        }

        private static void ExecuteAction(Vechicle vehicle, string commandToken, double parameter)
        {
            switch (commandToken)
            {
                case "Drive":
                    var result = vehicle.TryDrive(parameter);
                    Console.WriteLine(result);
                    break;
                case "Refuel":
                    vehicle.Refuel(parameter);
                    break;
                case "DriveEmpty":
                    var resultBus = vehicle.TryDrive(parameter, false);
                    Console.WriteLine(resultBus);
                    break;
            }
        }
    }
}
