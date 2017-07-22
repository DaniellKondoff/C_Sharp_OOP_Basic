using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CarSalesman
{
    public class Engine
    {
        public Engine(string engineModel, int power)
            :this(engineModel, power, -1, @"n/a")
        {

        }
        public Engine(string engineModel, int power, int displacement)
            :this(engineModel, power, displacement, @"n/a")
        {

        }
        public Engine(string engineModel, int power, string efficieny)
            :this(engineModel,power,-1,efficieny)
        {

        }
        public Engine(string engineModel,int power,int displacement,string efficieny)
        {
            this.EngineModel = engineModel;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficieny = efficieny;
        }
        public string EngineModel { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficieny { get; set; }
    }
}
