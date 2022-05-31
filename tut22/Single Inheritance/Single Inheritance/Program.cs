using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inheritance
{

    // In single inheritance we have only 2 class , Parent and child class.
    // child class acess all the member of parent class.
    // : is the symbol of inheritance in C#.


    class Parent
    {
        public void Show1()
        {
            Console.WriteLine("Parent class show method");
        }
    }
    class Child:Parent 
    {
        public void Show2()
        {
            Console.WriteLine("Child class show method");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            // Creating child class object.
            Child obj = new Child();
            obj.Show1();
            obj.Show2();

            // kya ho if ham Parent class ka object banau.
            Parent parent = new Parent();
            parent.Show1(); // to ab parent class ki hi methods ko call kar sakte h.
            // parent.Show2();  // error

            Console.ReadKey();

        }
    }
}
