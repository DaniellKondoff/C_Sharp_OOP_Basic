using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.RawData
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var carTokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string modelCar = carTokens[0];

                int engineSpeed = int.Parse(carTokens[1]);
                int enginePower = int.Parse(carTokens[2]);
                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(carTokens[3]);
                string cargoType = carTokens[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);


                double tire1Pressure = double.Parse(carTokens[5]);
                int tire1Age = int.Parse(carTokens[6]);
                double tire2Pressure = double.Parse(carTokens[7]);
                int tire2Age = int.Parse(carTokens[8]);
                double tire3Pressure = double.Parse(carTokens[9]);
                int tire3Age = int.Parse(carTokens[10]);
                double tire4Pressure = double.Parse(carTokens[11]);
                int tire4Age = int.Parse(carTokens[12]);

                Tire[] tires = new Tire[4];
                tires[0] = new Tire(tire1Pressure, tire1Age);
                tires[1] = new Tire(tire2Pressure, tire2Age);
                tires[2] = new Tire(tire3Pressure, tire3Age);
                tires[3] = new Tire(tire4Pressure, tire4Age);

                Car car = new Car(modelCar, engine, cargo, tires);
                cars.Add(car);

            }

            string cmd = Console.ReadLine();
            List<Car> sortedCars = new List<Car>();

            if (cmd == "fragile")
            {
                sortedCars = cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1)).ToList();
            }
            else
            {
                sortedCars = cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.EnginePower > 250).ToList();
            }

            foreach (var car in sortedCars)
            {
                Console.WriteLine($"{car.Model}");
            }
        }
    }
}
