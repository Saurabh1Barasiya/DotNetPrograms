using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genrick_dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Amit");

            dictionary.Add(2, "Ranu");

            dictionary.Add(3, "Janu");

            dictionary.Add(4, "Lalit");

            foreach (var item in dictionary.Keys)
            {
                Console.WriteLine(item+"--->"+dictionary[item]);
            }

            //dictionary.Clear();

            //foreach (var item in dictionary.Keys)
            //{
            //    Console.WriteLine(item + "--->" + dictionary[item]);
            //}


            dictionary.Remove(1);

            Console.WriteLine("After removing the key");

            foreach (var item in dictionary.Keys)
            {
                Console.WriteLine(item + "--->" + dictionary[item]);
            }


            Console.WriteLine(dictionary.ContainsKey(2));
            Console.WriteLine(dictionary.ContainsValue("Ranu"));

            Console.ReadKey();
        }
    }
}
