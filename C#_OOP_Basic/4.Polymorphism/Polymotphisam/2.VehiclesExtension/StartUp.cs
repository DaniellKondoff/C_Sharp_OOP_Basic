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
            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]),double.Parse(carInfo[3]));
            var truckInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            var busInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

            var vechles = new List<Vehicle>() {car,truck,bus};          

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vichlesTokens = Console.ReadLine().Split(' ');
                string cmd = vichlesTokens[0];
                string vichles = vichlesTokens[1];
                double quantity = double.Parse(vichlesTokens[2]);

                switch (vichles)
                {
                    case "Car":
                        if (cmd.Equals("Drive"))
                        {
                            car.Drive(quantity);
                        }
                        else
                        {
                            car.Refuel(quantity);
                        }
                        break;
                    case "Truck":
                        if (cmd.Equals("Drive"))
                        {
                            truck.Drive(quantity);
                        }
                        else
                        {
                            truck.Refuel(quantity);
                        }
                        break;
                    case "Bus":
                        if (cmd.Equals("Drive"))
                        {
                            bus.Drive(quantity);
                        }
                        else if (cmd.Equals("DriveEmpty"))
                        {
                            ((Bus)bus).DriveEmpty(quantity);
                        }
                        else
                        {
                            bus.Refuel(quantity);
                        }
                        break;
                }
            }

            foreach (var vechle in vechles)
            {
                Console.WriteLine($"{vechle.GetType().Name}: {vechle.FuelQuantity:f2}");
            }

        }
    }
}
