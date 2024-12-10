using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class HashSetDemo
    {
        static void Main(string[] args)
        {
            //HashSet
            // duplicates are not allowed
            HashSet<string> set = new HashSet<string>();

            set.Add("Amol");
            set.Add("Tushar");
            set.Add("Akshay");
            set.Add("Amol");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }

    }
}
