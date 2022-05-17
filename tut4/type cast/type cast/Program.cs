using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace type_cast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float f1 = 35e3F;
            // e = 0 
            // e3 = 000
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);



            //Implicit Casting(automatically) -converting a smaller type to a larger type size
            //char -> int -> long -> float -> double

            //Explicit Casting(manually) - converting a larger type to a smaller size type
            //double -> float -> long -> int -> char

            int a = 0;
            double b = a;  // implicit conversion.
            Console.WriteLine(a);
            Console.WriteLine(b);


            double c = 10d;
            int d = (int)c; // explicit conversion.

            Console.WriteLine(d);


            // one more way to convert 
            int e = 15;
            Console.WriteLine($"After converting to string {Convert.ToString(e)}");
            Console.WriteLine($"After converting to string {Convert.ToBoolean(e)}");
            Console.WriteLine($"After converting to string {Convert.ToInt64(e)}");

            Console.ReadKey();
        }
    }
}
