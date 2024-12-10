using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class ProductList
    {
        public int Price { get; set; }
        public string Name { get; set; }

        public ProductList( int price,string name)
        {
            Price=price;
            Name = name;

        }
        public override string ToString()
        {
            return $"Product Name: {Name}, Price: {Price}";
        }
    }
}
