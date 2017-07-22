using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length,double width,double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get { return length; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Length)} cannot be zero or negative.");
                }
                length = value;
            }
        }
        public double Width
        {
            get { return width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Width)} cannot be zero or negative.");

                }
                width = value;
            }
        }
        public double Height
        {
            get { return height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Height)} cannot be zero or negative.");
                }
                height = value;
            }
        }


        public double GetSurfaceArea()
        {
            return (2 * this.Length * this.Width) + (2 * this.Length * this.Height) + (2 * this.Width * this.Height);
        }

        public double GetLiteralSUrfaceArea()
        {
            return (2 * this.Length * this.Height) + (2 * this.Width * this.Height);
        }

        public double GetVolum()
        {
            return this.Length * this.Width * this.Height;
        }
    }
}
