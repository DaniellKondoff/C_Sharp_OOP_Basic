using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.DrawingTool
{
    public class Square : Shape
    {
        public double side;

        public Square(double side)
        {
            this.side = side;
        }
        public override void Draw()
        {
            Console.WriteLine("{0}{1}{0}", '|', new string('-', (int)this.side));
            for (double i = 0; i < this.side - 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", '|', new string(' ', (int)this.side));
            }
            Console.WriteLine("{0}{1}{0}", '|', new string('-', (int)this.side));
        }
    }
}
