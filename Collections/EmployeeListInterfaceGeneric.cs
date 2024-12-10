using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class EmployeeListInterfaceGeneric
    {
        //        List<int> list1 = new List<int>();
        //        list1.Add(10);

        //            List<string> list2 = new List<string>();
        //        list2.Add("Rohan");

        //            List<Employee> list3 = new List<Employee>();

        //        list3.Add(new Employee { Id = 1, Name = "Suraj", Salary = 33000 });

        //            Stack<string> s1 = new Stack<string>();
        //    s1.Push();

        //            Queue<double> q = new Queue<double>();
        //    q.Enqueue()


        //Dictionary<int, string> pair = new Dictionary<int, string>();

        //    pair.Add(1,"Hello");

        //    }
        //static void Main(string[] args)
        //{

        //    List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        //    numbers.Add(6);
        //    numbers.AddRange(new List<int> { 7, 8, 9 });

        //    foreach (int i in numbers)
        //    {
        //        Console.WriteLine(i);
        //    }

        //    numbers.Remove(3);
        //    numbers.RemoveAt(0);
        //    Console.WriteLine("\n\nAfter Remove(3) and RemoveAt(0):");
        //    foreach (int i in numbers)
        //    {
        //        Console.WriteLine(i);
        //    }

        //    numbers.Sort();
        //    Console.WriteLine("\n\nAfter sort:");
        //    foreach (int i in numbers)
        //    {
        //        Console.WriteLine(i);
        //    }

        //    numbers.Reverse();
        //    Console.WriteLine("\n\nAfter Reverse:");
        //    foreach (int i in numbers)
        //    {
        //        Console.WriteLine(i);
        //    }

        //    numbers.Clear();
        //    Console.WriteLine("\n\nAfter clear:");
        //    Console.WriteLine("List Count:" +numbers.Count);

        //    List<ProductList> p = new List<ProductList>
        //    {
        //        new ProductList(70000,"Laptop"),
        //        new ProductList(30000,"Mobile")
        //    };
        //    p.Add(new ProductList(150, "Pendrive"));
        //    Console.WriteLine("\nProduct List:");
        //    foreach (var Product in p)
        //    {
        //        Console.WriteLine($"{Product.Name}: ${Product.Price}");
        //    }

        //    Stack<int> s = new Stack<int>();
        //    s.Push(1);
        //    s.Push(2);
        //    s.Push(3);

        //    Console.WriteLine("\n\nStack Elements:");
        //    foreach (var item in s)
        //    {
        //        Console.WriteLine(item); //3,2,1
        //    }

        //    Console.WriteLine("\nPeek at the top item without removing:"+s.Peek()); //3
        //    Console.WriteLine("Stack count:"+ s.Count);

        //    Console.WriteLine("\nPopping one item:" +s.Pop());
        //    Console.WriteLine("\n Stack Elements:");
        //    foreach (var item in s)
        //    {
        //        Console.WriteLine(item); //3,2,1
        //    }
        //    Console.WriteLine("Stack count:" + s.Count);

        //    Queue<string> q = new Queue<string>();
        //    q.Enqueue("one");
        //    q.Enqueue("two");
        //    q.Enqueue("three");

        //    Console.WriteLine("Queue Elements:");
        //    foreach (var item in q)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    Console.WriteLine("\nPeek at the front item without removing: " + q.Peek());
        //    Console.WriteLine("Current queue count: " + q.Count);


        //    Console.WriteLine("\nDequeue one item: " + q.Dequeue());

        //    Console.WriteLine("\nQueue contents after one dequeue:");
        //    foreach (var item in q)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    Console.WriteLine("\nCurrent queue count: " + q.Count);


        //    Dictionary<int, string> pair = new Dictionary<int, string>
        //    {
        //        {1,"one" },
        //        {2,"two" },
        //        {3,"three"}
        //    };

        //    pair.Add(4, "Four");
        //    Console.WriteLine("\nDictionary Contents:");
        //    foreach (var item in pair)
        //    {
        //        Console.WriteLine($"{item.Key}: {item.Value}");
        //    }

        //    // ContainsKey - Check if a specific key exists
        //    Console.WriteLine("\nContains key 2: " + pair.ContainsKey(2));  // True
        //    Console.WriteLine("Contains key 5: " + pair.ContainsKey(5));  // False

        //    // ContainsValue - Check if a specific value exists
        //    Console.WriteLine("\nContains value 'Two': " + pair.ContainsValue("Two"));  // True
        //    Console.WriteLine("Contains value 'Five': " + pair.ContainsValue("Five"));  // False

        //    // Remove a key-value pair by key
        //    pair.Remove(3);  // Removes the key-value pair with key 3
        //    Console.WriteLine("\nAfter removing key 3:");
        //    foreach (var kvp in pair)
        //    {
        //        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        //    }

        //    // TryGetValue - Safely retrieve a value by key
        //    if (pair.TryGetValue(2, out string value))
        //    {
        //        Console.WriteLine("\nKey 2's value: " + value);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Key 2 not found.");
        //    }

        //    // Peek at the value of a specific key using TryGetValue (instead of direct access)
        //    if (pair.TryGetValue(4, out string value4))
        //    {
        //        Console.WriteLine("Key 4's value: " + value4);
        //    }

        //    Console.WriteLine("\nDictionary Keys:");
        //    foreach (var key in pair.Keys)
        //    {
        //        Console.WriteLine(key);
        //    }

        //    Console.WriteLine("\nDictionary Values:");
        //    foreach (var val in pair.Values)
        //    {
        //        Console.WriteLine(val);
        //    }

        //    // Count - Get the number of key-value pairs
        //    Console.WriteLine("\nCurrent dictionary count: " + pair.Count);

        //    // Clear - Removes all key-value pairs
        //    pair.Clear();
        //    Console.WriteLine("\nAfter clearing:");
        //    Console.WriteLine("Dictionary count: " + pair.Count);  // 0

        //    // Add items back to demonstrate GetEnumerator
        //    pair.Add(1, "One");
        //    pair.Add(2, "Two");
        //    pair.Add(3, "Three");

        //    // GetEnumerator - Iterate through the dictionary manually
        //    var enumerator = pair.GetEnumerator();
        //    Console.WriteLine("\nIterating using GetEnumerator:");
        //    while (enumerator.MoveNext())
        //    {
        //        var current = enumerator.Current;
        //        Console.WriteLine($"{current.Key}: {current.Value}");
        //    }

        //        SortedList<int, string> sortedList = new SortedList<int, string>
        //        {
        //            { 3, "Three" },
        //            { 1, "One" },
        //            { 2, "Two" }
        //        };

        //        // Add a new key-value pair
        //        sortedList.Add(4, "Four");

        //        // Access an element by key
        //        Console.WriteLine($"Value for key 2: {sortedList[2]}");

        //        // Use TryGetValue to safely get a value
        //        if (sortedList.TryGetValue(2, out string value))
        //        {
        //            Console.WriteLine($"Key 2 has value: {value}");
        //        }

        //    // Check if a key exists
        //    bool hasKey3 = sortedList.ContainsKey(3);
        //    Console.WriteLine($"Contains key 3: {hasKey3}");

        //        // Check if a value exists
        //        bool hasValueOne = sortedList.ContainsValue("One");
        //    Console.WriteLine($"Contains value 'One': {hasValueOne}");

        //        // Iterate over the sorted list
        //        Console.WriteLine("\nSortedList contents:");
        //        foreach (var kvp in sortedList)
        //        {
        //            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        //        }

        //// Remove a key-value pair by key
        //sortedList.Remove(3);
        //Console.WriteLine("\nAfter removing key 3:");
        //foreach (var kvp in sortedList)
        //{
        //    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        //}

        //// Remove a key-value pair by index
        //sortedList.RemoveAt(1);
        //Console.WriteLine("\nAfter removing element at index 1:");
        //foreach (var kvp in sortedList)
        //{
        //    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        //}

        //// Clear the list
        //sortedList.Clear();
        //Console.WriteLine("\nAfter clearing the SortedList:");
        //Console.WriteLine($"Count: {sortedList.Count}");
        //  }


    }
}