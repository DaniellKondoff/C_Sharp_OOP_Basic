using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DateModifier
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            DateModifier dm = new DateModifier();
            var result = Math.Abs(dm.GetDifferenceBetweenDate(date1, date2));
            Console.WriteLine(result);
        }
    }
}
