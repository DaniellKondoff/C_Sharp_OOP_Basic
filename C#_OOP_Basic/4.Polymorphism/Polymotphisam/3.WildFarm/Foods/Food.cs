using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.WildFarm.Foods
{
    public abstract class Food
    {
        public Food(int foodQuantity)
        {
            this.Quantity = foodQuantity;
        }
        public int Quantity { get; set; }
    }
}
