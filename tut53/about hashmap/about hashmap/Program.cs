using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace about_hashmap
{
    // Hashtable uses key-value pair.
    // yaha order nahi hota h in according to me.
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable  hashtable = new Hashtable();
            hashtable.Add("Id", 12);
            hashtable.Add("Name", "saurabh");
            hashtable.Add("age", 22);
            hashtable.Add("Address", "Haraai");
            hashtable.Add("Salary", 24000);

            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine(item+" "+hashtable[item]);
            }


            Hashtable hashtable1 = new Hashtable()
            {
                {"Id", 123 },
                {"Name", "peeyush" },
                {"age", 23 },
                { "Address", "Haraai"},
                {"Salary", 28000 }
            };
            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine(item + " " + hashtable1[item]);
            }
            Console.ReadKey();
        }
    }
}
