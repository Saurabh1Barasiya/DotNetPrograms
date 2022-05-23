using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace About_Constructor
{
    class Student
    {


        // 👀👀👀👀👀👀👀
        // Constructor overloding is possible.
        // when we create object so c# default constructor create karta h.
        // Constructor name and class name should be same.
        // Constructor modifier must be public or internal.


        // 👌👌👌👌👌👌👌👌👌👌👌👌👌👌👌👌👌👌👌
        public Student()
        {
            Console.WriteLine("Default constructor");
        }

        public Student(int a, int b)
        {
            Console.WriteLine("two argument constructor");
        }

        public Student(int a, int b, int c)
        {
            Console.WriteLine("three argument constructor");
        }
        public Student(string a, string b, string c)
        {
            Console.WriteLine("string three argument constructor");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student("5","6","3");
            // when we create object so c# default constructor create karta h.
            Console.ReadKey();
        }
    }
}
