using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SppedRacing
{
    class StartIp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string modelName = inputLine[0];
                double fuelAmount = double.Parse(inputLine[1]);
                double fuelConsumption = double.Parse(inputLine[2]);

                Car car = new Car(modelName, fuelAmount, fuelConsumption);
                cars.Add(car);   
            }

            string cmd = Console.ReadLine();
            while (cmd != "End")
            {
                var tokens= cmd.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string carModel = tokens[1];
                int amountOfKm = int.Parse(tokens[2]);

                Car currentCar = cars.FirstOrDefault(c => c.Model == carModel);

                currentCar.Drive(amountOfKm);
                cmd = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine("{0} {1:F2} {2}", car.Model, car.FuelAmount, car.DistanceTraveled);
            }
        }
    }
}
