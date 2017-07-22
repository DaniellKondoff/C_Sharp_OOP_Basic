using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CarSalesman
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> carsList = new List<Car>();
            List<Engine> engineList = new List<Engine>();
            int numberOfEngines = int.Parse(Console.ReadLine());
            int displcament = 0;

            for (int i = 0; i < numberOfEngines; i++)
            {
                var engineInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Engine engine = null;

                if (engineInput.Length==2)
                {
                    engine = new Engine(engineInput[0], int.Parse(engineInput[1]));
                }
                else if (engineInput.Length==4)
                {
                    engine = new Engine(engineInput[0], int.Parse(engineInput[1]),int.Parse(engineInput[2]),engineInput[3]);
                }
                else if (engineInput.Length==3 && int.TryParse(engineInput[2],out displcament))
                {
                    engine = new Engine(engineInput[0], int.Parse(engineInput[1]), int.Parse(engineInput[2]));
                }
                else
                {
                    engine = new Engine(engineInput[0], int.Parse(engineInput[1]), (engineInput[2]));

                }

                engineList.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                var carInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Car car = null;
                var currentEngine = engineList.FirstOrDefault(e => e.EngineModel == carInput[1]);
                int weight = 0;

                if (carInput.Length==2)
                {
                    car = new Car(carInput[0], currentEngine);
                }
                else if (carInput.Length==4)
                {
                    car = new Car(carInput[0], currentEngine,int.Parse(carInput[2]),carInput[3]);
                }
                else if (carInput.Length ==3 && int.TryParse(carInput[2],out weight))
                {
                    car = new Car(carInput[0], currentEngine, int.Parse(carInput[2]));
                }
                else
                {
                    car = new Car(carInput[0], currentEngine,carInput[2]);
                }
                carsList.Add(car);
            }

            foreach (var car in carsList)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.EngineModel}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine("    Displacement: {0}",car.Engine.Displacement == -1 ? @"n/a" : car.Engine.Displacement.ToString());
                Console.WriteLine($"    Efficiency: {car.Engine.Efficieny}");
                Console.WriteLine("  Weight: {0}",car.Weight==-1? @"n/a" : car.Weight.ToString());
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
