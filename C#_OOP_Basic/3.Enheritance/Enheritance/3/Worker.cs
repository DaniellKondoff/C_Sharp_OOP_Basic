using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursWeek;
        public Worker(string firstName, string lastName,decimal weekSalary,decimal workHoursWeek) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursWeek = workHoursWeek;
        }

        public override string LastName
        {
            get
            {
                return base.LastName;
            }

            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }
                base.LastName = value;
            }
        }
        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            }
        }
        public decimal WorkHoursWeek
        {
            get
            {
                return this.workHoursWeek;
            }
            set
            {
                if (value <1 || value >12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workHoursWeek = value;
            }
        }

        public decimal GetSalaryPerHour()
        {
            decimal daySalary = this.WeekSalary / 5;
            var salaryHour= daySalary / this.WorkHoursWeek;
            return salaryHour;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstName}");
            sb.AppendLine($"Last Name: {this.LastName}");
            sb.AppendLine($"Week Salary: {this.WeekSalary:f2}");
            sb.AppendLine($"Hours per day: {this.WorkHoursWeek:f2}");
            sb.AppendLine($"Salary per hour: {this.GetSalaryPerHour():f2}");
            return sb.ToString();
        }
    }
}
