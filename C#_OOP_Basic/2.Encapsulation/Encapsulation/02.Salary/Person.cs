using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private double salary;

    public Person(string firstName, string lastName, int age,double salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }
    public Person()
    {

    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }
        set
        {
            this.lastName = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 0)
            {
                throw new Exception("The Age cannot be negative");
            }
            this.age = value;
        }
    }

    public double Salary
    {
        get
        {
            return this.salary;
        }
        set
        {
            this.salary = value;
        }
    }

    public void IncreaseSalary(double bonus)
    {
        if (this.Age > 30)
        {
            this.Salary += this.Salary * bonus / 100;
        }
        else
        {
            this.Salary += this.Salary * bonus/200;
        }
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} get {this.Salary} leva";
    }
}

