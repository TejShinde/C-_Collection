using FirstDemo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class IEnumerableMain
    {
        static void Main(string[] args)
        {
            ////  Array
            //  int[] arr = new int[] { 1, 2, 3, 4, 5 };
            ////  IEnumerable
            //  foreach (var item in arr)
            //  {
            //      Console.WriteLine(item); //1  2   3  4  5
            //  }

            //  Team india = new Team();
            //  foreach (Player p in india)
            //  {
            //      Console.WriteLine(p);
            //  }

            Player rohit = new Player(80, "Rohit");
            Player virat = new Player(80, "Virat");
            // object with call  --> parameter
            //int result=rohit.CompareTo(virat);
            CheckRuns c1 = new CheckRuns();
            int result = c1.Compare(rohit, virat);
            if (result == 1)
            {
                Console.WriteLine("Rohit scored more runs than virat");
            }
            else if (result == -1)
            {
                Console.WriteLine("Virat scored more runs than Rohit");
            }
            else
            {
                Console.WriteLine("Both scored equal");
            }
        }

    }
}
