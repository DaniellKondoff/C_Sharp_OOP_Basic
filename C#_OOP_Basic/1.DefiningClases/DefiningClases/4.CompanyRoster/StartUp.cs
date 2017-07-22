using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CompanyRoster
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employeeList = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = inputLine[0];
                decimal salary = decimal.Parse(inputLine[1]);
                string position = inputLine[2];
                string department = inputLine[3];
                Employee employe = new Employee(name,salary,position,department);

                if (inputLine.Length == 5)
                {
                    int age;
                    bool isDigit = int.TryParse(inputLine[4], out age);
                    if (isDigit)
                    {
                        employe.Age = age;
                    }
                    else
                    {
                        employe.Email = inputLine[4];
                    }
                }
                else if (inputLine.Length==6)
                {
                    int age;
                    bool isDigit = int.TryParse(inputLine[5], out age);
                    if (isDigit)
                    {
                        employe.Age = age;
                        employe.Email = inputLine[4];
                    }
                    else
                    {
                        employe.Email = inputLine[5];
                        employe.Age = int.Parse(inputLine[4]);
                    }
                }

                employeeList.Add(employe);
            }

            var HighSalaryDepartment = employeeList.GroupBy(e => e.Department).OrderByDescending(d=>d.Average(e=>e.Salary)).Take(1).ToList();

            foreach (var department in HighSalaryDepartment)
            {
                Console.WriteLine($"Highest Average Salary: {department.Key}");

                foreach (var person in department.OrderByDescending(p=>p.Salary))
                {
                    Console.WriteLine($"{person.Name} {person.Salary:f2} {person.Email} {person.Age}");
                }
            }
        }
        
    }
}
