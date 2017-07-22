using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1.ClassPerson
{
    public class StartUp
    {
        public class Person
        {
            public string name;
            public int age;

        }
       public static void Main(string[] args)
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);

        }
    }
}
