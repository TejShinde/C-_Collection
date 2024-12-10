using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Product : IComparable<Product>
    {
        public int Price { get; set; }
        public string Name { get; set; }

        public Product(int price, string name)
        {
            Price = price;
            Name = name;
        }

        public int CompareTo(Product other)
        {
            if (this.Price > other.Price)
                return 1;
            else if (this.Price < other.Price)
                return -1;
            else
                return 0;
        }
    }
    public class CheckPrice : IComparer<Product>
    {
        public int Compare(Product p1, Product p2)
        {
            return p1.CompareTo(p2);
        }
    }
}
