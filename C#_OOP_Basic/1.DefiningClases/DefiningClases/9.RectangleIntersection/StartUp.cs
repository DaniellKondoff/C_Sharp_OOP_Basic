using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Rectangle> listOfRectangle = new List<Rectangle>();
            List<string[]> listOfpairs = new List<string[]>();

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int numberOfRectangles = input[0];
            int numberOfIntersectionChecks = input[1];

            for (int i = 0; i < numberOfRectangles; i++)
            {
                var tokens = Console.ReadLine().Split(' ').ToArray();

                string id = tokens[0];
                double width = double.Parse(tokens[1]);
                double height = double.Parse(tokens[2]);
                double topLeftCornerX = double.Parse(tokens[3]);
                double topLeftCornerY = double.Parse(tokens[4]);

                Rectangle current = new Rectangle()
                {
                    ID = id,
                    Width = width,
                    Height = height,
                    TopLeftCornerX = topLeftCornerX,
                    TopLeftCornerY = topLeftCornerY
                };

                listOfRectangle.Add(current);
            }

            for (int j = 0; j < numberOfIntersectionChecks; j++)
            {
                string[] pair = Console.ReadLine().Split(' ');
                listOfpairs.Add(pair);
            }

            Rectangle rc = new Rectangle();

            foreach (var pair in listOfpairs)
            {
                rc.IsIntersect(pair[0], pair[1], listOfRectangle);
            }
        }
    }
}
