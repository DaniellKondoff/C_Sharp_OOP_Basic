using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CreatingConstructors
{
    public class Person
    {
        public string name;
        public int age;

        public Person()
            :this(1,"No name")
        {
            //this.name = "No name";
            //this.age = 1;
        }

        public Person(int age)
            :this(age,"No Name")
        {
            //this.age = age;
            //this.name = "No name";
        }
        public Person(int age, string name)
        {
            this.name = name;
            this.age = age;
        }
    }
}
