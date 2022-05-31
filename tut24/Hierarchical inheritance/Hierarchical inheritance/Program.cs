using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_inheritance
{

    // In Hierarchical inheritance we have only 1 Parent class ,and all the class inherited by Parent class.

    class Base
    {
        public void show()
        {
            Console.WriteLine("Parent class method");
        }
    }

    class Child1 : Base
    {
        public void show1()
        {
            Console.WriteLine("Child1 class method");
        }
    }

    class Child2 : Base
    {
        public void show2()
        {
            Console.WriteLine("Child2 class method");
        }
    }

    class Child3 : Base
    {
        public void show3()
        {
            Console.WriteLine("Child3 class method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // here yaha jitni bhi drived class h vo sabhi Parent class ke show() ko use karegi.
            Child3 obj3 = new Child3();
            obj3.show();
            obj3.show3();

            Child2 obj2 = new Child2();
            obj2.show();
            obj2.show2();


            Child1 obj1 = new Child1();
            obj1.show();
            obj1.show1();
            Console.ReadKey();
        
        }
    }
}
