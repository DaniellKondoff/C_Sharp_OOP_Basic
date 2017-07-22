using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CarSalesman
{
    public class Car
    {

        public Car(string modelName, Engine engine)
            :this(modelName,engine,-1,@"n/a")
        {

        }
        public Car(string modelName, Engine engine, string color)
            :this(modelName, engine, -1, color) 
        {

        }
        public Car(string modelName, Engine engine, int weight)
            :this(modelName,engine,weight, @"n/a")
        {

        }
        public Car(string modelName,Engine engine,int weight,string color)
        {
            this.Model = modelName;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

    }
}
