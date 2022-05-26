using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Constructor
{

    class Student
    {
        // 👀👀👀👀👀👀👀👀👀👀👀👀👀👀

        // if ham private constructor ka use karte h to ham us class ka object nahi bana sakte .
        // and us class ka inherit bhi nahi kar sakte.

        // to jab bhi hame pure static work karna rahta tabhi ham private constructor ka use karte  h kyoki ham onject to bana hi nahi sakte.

        public static int pi;

        private Student()
        {
            pi = 3;
        }
        public static void Display()
        {
            Console.WriteLine($"Value of PI {pi}");
            // why this gives me 0 🤦‍♂️🤦‍♂️🤦‍♂️🤦‍♂️🤦‍♂️🤦‍♂️🤦‍♂️🤦‍♂️🤦‍♂️🤦‍♂️
        }
    }

    //class person : Student
    //{
    //    //if ham private constructor ka use karte h to ham us class ka object nahi bana sakte.
    //    // and us class ka inherit bhi nahi kar sakte.
    //}
    class Program
    {
        static void Main(string[] args)
        {
            // Student obj = new Student(); // error 
           Student.Display();
           Console.ReadKey();
        }
    }
}
