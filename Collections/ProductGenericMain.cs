using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class ProductGenericMain
    {
        static void Main(string[] args)
        {
            ProductGeneric<int> p1 = new ProductGeneric<int>(70000, "Laptop");
            ProductGeneric<int> p2 = new ProductGeneric<int>(20000, "Mobile");

            CheckPrice<int> c = new CheckPrice<int>();
            int res = c.Compare(p1, p2);

            if (res == 1)
            {
                Console.WriteLine($"{p1.Name} is more expensive than {p2.Name} ");
            }
            else if (res == -1)
            {
                Console.WriteLine($"{p2.Name} is more expensive than {p1.Name} ");
            }
            else
            {
                Console.WriteLine("Both products have same price");
            }
        }
    }
}
