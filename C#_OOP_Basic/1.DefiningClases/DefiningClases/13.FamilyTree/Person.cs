using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.FamilyTree
{
    public class Person
    {
        private string name;
        private string birthDate;
        private List<Person> children;

        public Person()
        {
            this.children = new List<Person>();
        }

        public Person(string name, string date) : this()
        {
            this.Name = name;
            this.BirthDate = date;
        }

        public string Name
        {
            get { return this.name; }
            set {this. name = value; }
        }

        public string BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }

        public void AddChild(Person child)
        {
            this.children.Add(child);
        }
        public IReadOnlyList<Person> Children
        {
            get { return this.children.AsReadOnly(); }
        }
        public void AddChildrenInfo(string name, string date)
        {
            if (this.children.FirstOrDefault(c => c.Name == name) != null)
            {
                this.children.FirstOrDefault(c => c.Name == name).BirthDate = date;
                return;
            }
            if (this.children.FirstOrDefault(c => c.BirthDate == date) != null)
            {
                this.children.FirstOrDefault(c => c.BirthDate == date).Name = name;
            }
        }

        public Person FindChildName(string childName)
        {
            return this.children.FirstOrDefault(c => c.Name == childName);
        }

    }
}
