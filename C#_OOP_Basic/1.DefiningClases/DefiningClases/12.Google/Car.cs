using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Google
{
    public class Car
    {
        public Car(string model,string speed)
        {
            this.Speed = speed;
            this.Model = model;
        }
        public string Model { get; set; }
        public string Speed { get; set; }

        public override string ToString()
        {
            return $"{this.Model} {this.Speed}";
        }
    }
}
