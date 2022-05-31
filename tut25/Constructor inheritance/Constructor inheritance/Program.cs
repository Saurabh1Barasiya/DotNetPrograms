using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_inheritance
{
    class Parent
    {
        /*
        public Parent()
        {
            Console.WriteLine("Parent class constructor");
        }
        */

        public Parent(string message)
        {
            Console.WriteLine($"Parent class constructor message {message}");
        }
    }

    class Child : Parent
    {
        // 👀👀👀👀👀👀👀👀
        // Aesa khud compiler likhta h --> base()

        //public Child() : base()
        //{
        //    Console.WriteLine("Child class constructor");
        //}

        //public Child() 
        //{
        //    Console.WriteLine("Child class constructor");
        //}

        public Child() : base("Hello c#")
        {
            // ham cahte h ki child class ka constructor chalne se pahle Base class ka parameterized constructor chale.
            // to ham base() ka use karege.
            Console.WriteLine("Child class constructor");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // To 1 rule h jab bhi app chld class ka object banate ho and inheritance ho raha h.
            // to child class ka default (Parameter less) constructor khud parent class ke default (Parameter less) constructor ko call karta h.
            // but Parameter constructor ke case me aesa nahi hoa hamko khud call karna padta h.
            // with the help of base() keyword.

            Child obj = new Child();
            Console.ReadKey();
        }
    }
}
