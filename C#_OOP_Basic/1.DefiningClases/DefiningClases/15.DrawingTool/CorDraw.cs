using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.DrawingTool
{
    public class CorDraw
    {
        public CorDraw(Shape shape)
        {
            this.Draw(shape);
        }

        public void Draw(Shape shape)
        {
            shape.Draw();
        }
    }
}
