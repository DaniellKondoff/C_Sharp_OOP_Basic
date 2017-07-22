using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.DrawingTool
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string typeOfShape = Console.ReadLine();
            Shape shape = null;
            if (typeOfShape == "Square")
            {
                double side = double.Parse(Console.ReadLine());
                Square square = new Square(side);
                shape = square;
            }
            else
            {
                double width = double.Parse(Console.ReadLine());
                double lenght = double.Parse(Console.ReadLine());
                Rectangle rect = new Rectangle(width, lenght);
                shape = rect;
            }

            CorDraw drawe = new CorDraw(shape);
        }
    }
}
