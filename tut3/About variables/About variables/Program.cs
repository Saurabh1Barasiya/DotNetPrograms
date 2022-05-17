using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace About_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  a = 0;
            a = a + 1;
            a = a + 2;
            Console.WriteLine($"Updated value of a is {a}");

            const int b = 0;
            //b = 5;   constant can never be changable.
            //Console.WriteLine($"{b}");


            bool cjeck = false;
            Console.WriteLine($"Value of check is {cjeck}");
            cjeck = true;
            Console.WriteLine($"Updated value is {cjeck}");


            char d = 'z';  
            //here we use single code
            Console.WriteLine($"Chracter value is {d}");



            // in string we use double code.

            string s = "Saurabh";
            Console.WriteLine($"The value of s is {s}");

            double myDoubleNum = 5.99D;
            Console.WriteLine($"value of double {myDoubleNum}");

            Console.ReadKey();
        }
    }
}
