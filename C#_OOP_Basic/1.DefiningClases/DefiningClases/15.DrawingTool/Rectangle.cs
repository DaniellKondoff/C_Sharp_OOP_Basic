using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.DrawingTool
{
    class Rectangle : Shape
    {
        public double lenght;
        public double width;

        public Rectangle(double width, double lenght)
        {

            this.width = width;
            this.lenght = lenght;
        }

        public override void Draw()
        {
            Console.WriteLine("{0}{1}{0}", '|', new string('-', (int)this.width));
            for (double i = 0; i < this.lenght - 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", '|', new string(' ', (int)this.width));
            }
            Console.WriteLine("{0}{1}{0}", '|', new string('-', (int)this.width));
        }
    }
}
