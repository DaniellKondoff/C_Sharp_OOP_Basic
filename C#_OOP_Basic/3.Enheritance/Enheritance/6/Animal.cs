using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name,int age,string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid input!");
                }

                this.name = value;
            }
        }
        public int Age {
            get { return this.age; }
            set
            {
                if (value <0 || string.IsNullOrWhiteSpace(value.ToString()))
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.age = value;
            }
        }
        public string Gender
        {
            get { return gender; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                gender = value;
            }
        }

        public abstract void ProduceSound();

        public override string ToString()
        {
            return $"{this.Name} {this.Age} {this.Gender}";
        }

    }
}
