using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1.ClassBox
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(length, width, height);
                Console.WriteLine($"Surface Area - {box.GetSurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area - {box.GetLiteralSUrfaceArea():f2}");
                Console.WriteLine($"Volume - {box.GetVolum():f2}");
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }

        }
    }
}
