using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DateModifier
{
    public class DateModifier
    {
        public double GetDifferenceBetweenDate(string date1, string date2)
        {
            DateTime startDate = DateTime.Parse(date1);
            DateTime endDate = DateTime.Parse(date2);

            var totalDays = (endDate - startDate).TotalDays;

            return totalDays;
        }
    }
}
