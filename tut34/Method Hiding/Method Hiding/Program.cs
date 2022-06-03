using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hiding
{

    // Method hiding yaha ham new keyword ka use karege.
    // if new na likhe to warning aata h. but new likhna matlab ham forcefully bol rahe h ki ham method hiding kar rahe h. 
    class Parent
    {
        public void show()
        {
            Console.WriteLine("Parent class method");
        }
    }
    class Child : Parent
    {
        public new void show()
        {
            // base.show(); base means parent class ka function chalega.
            Console.WriteLine("Child class method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parent parent = new Parent();
            //parent.show();

            //Child child = new Child();
            //child.show();

            Child child = new Child();

            ((Parent)child).show(); // type conversion. child ka object parent me convert ho gaya h.

            Console.ReadKey();
        }
    }
}
