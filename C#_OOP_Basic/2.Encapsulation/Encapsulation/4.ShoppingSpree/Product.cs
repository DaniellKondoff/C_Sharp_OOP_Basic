using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal price;

        public Product(string name,decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.price = value;
            }
        }
    }
}
