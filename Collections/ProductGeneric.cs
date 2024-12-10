using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
        public class ProductGeneric<T> : IComparable<ProductGeneric<T>>
        {
            public int Price { get; set; }
            public string Name { get; set; }

            public ProductGeneric(int price, string name)
            {
                Price = price;
                Name = name;
            }

            public int CompareTo(ProductGeneric<T> other)
            {
                if (this.Price > other.Price)
                    return 1;
                else if (this.Price < other.Price)
                    return -1;
                else
                    return 0;
            }
        }

    public class CheckPrice<T> : IComparer<ProductGeneric<T>>
    {
        public int Compare(ProductGeneric<T> p1, ProductGeneric<T> p2)
        {
            return p1.CompareTo(p2);
        }
    }

}
