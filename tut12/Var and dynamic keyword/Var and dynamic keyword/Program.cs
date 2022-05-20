using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_and_dynamic_keyword
{
    internal class Program
    {

        static void greet(string s)
        {
            // ham yaha formal argment ke roop me var ka use nahi kar sakte.
            // ham yaha return type ke roop me bhi var ka use nahi kar sakte .
            Console.WriteLine(s);
        }


        public static dynamic Check(dynamic c)
        {
            c = 100;
            Console.WriteLine("Dynamic process start...");
            return c;
        }
        static void Main(string[] args)
        {
            // jab ham var wala variable banate h to initilize karna jaruri h. 
            //var b;
            var a = "saurabh";
            //a = 178;   // ham aesa nahi kar sakte kyoki ye value type hota h not dynamic.

           
            Console.WriteLine(a);


            // jab ham metdhos dedfine karte h to return type me ham var ka use nahi kar sakte .
            // and formal argument me bhi ham var ka use nahi kar sakte .
            var s = "Peeyush";
            Program.greet(s);


            // jo kaam ham var se nahi kar sakte vo ham dynamic ka use karke kar sakte h.

            dynamic c; // no error without initilize.
            dynamic d = 10;

            d = "bdsvkj"; // ham value bhi change kar sakte h no error.



            Console.WriteLine(d);

            dynamic e = Program.Check(d);
            Console.WriteLine($"dynamic value {e}");


            Console.ReadKey();
        }
    }
}