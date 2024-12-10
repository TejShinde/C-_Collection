using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class HashTableDemo
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add(91, "IND");// Adds the key 91 with the value "IND" (India)
            ht.Add(63, "AUS");
            ht.Add(1, "USA");
            ht.Remove(1);// if match it will remove that object

            // DictionaryEntry is a built in struct type to read Key & Value from the Hashtable
            // DictionaryEntry is used here to represent each item (key-value pair) in the Hashtable

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
        }

    }
}
