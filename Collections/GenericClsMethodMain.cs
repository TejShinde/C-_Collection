using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Collections.GenericClsMethod;

namespace Collections
{
    internal class GenericClsMethodMain
    {
        static void Swap<T>(T a, T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a= {a} , b= {b}");
        }
        static void Main(string[] args)
        {
            GenericCls<int> g1 = new GenericCls<int>();
            g1.Add(10);
            Console.WriteLine(g1.Get());

            //GenericCls<Product> g2 = new GenericCls<Product>();
            //g2.Add(new ProductList { Price = 10, Name = "Pen" });
            //Console.WriteLine(g2.Get());
            GenericCls<ProductList> g2 = new GenericCls<ProductList>();
            g2.Add(new ProductList(10, "Pen"));
            Console.WriteLine(g2.Get());

            GenericCls<string> g3 = new GenericCls<string>();
            g3.Add("Pune");
            Console.WriteLine(g3.Get());

            Swap<int>(10, 20);
            Swap<string>("Hello", "Hi");
        }
    }
}
