using System.Collections;

namespace _24_CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Hashtable table = new Hashtable();
            table.Add(1, "mythology");
            table.Add(2, "biology");
            table.Add(3, "pshycology");
            table.Add(4, "history");
            table.Add(5, "mathematics");

            foreach (int key in table.Keys)
            {
                Console.WriteLine($"key is: {key}");
            }

            foreach (string value in table.Values)
            {
                Console.WriteLine($"value is: {value}");
            }

            foreach (int key in table.Keys)
            {
                Console.WriteLine($"value of {key} is {table[key]}");
            }

            List<string> list = new List<string>();
            list.Add("hello");
            list.Add("bye");
            list.Add("welcome");
            list.Add("happy");

            foreach (string str in list)
            {
                Console.WriteLine($"the value is {str}");
            }
        }
    }
}
