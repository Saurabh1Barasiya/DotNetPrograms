using System;

namespace Multilevel_Inheritance
{
    class Base
    {
        public void show()
        {
            Console.WriteLine("Base class method");
        }
    }

    class Derived1 : Base
    {
        public void show1()
        {
            Console.WriteLine("Derived1 class method");
        }
    }

    class Derived2 : Derived1
    {
        public void show2()
        {
            Console.WriteLine("Derived2 class method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // yaha  Derived1 class Base and Derived2 , Derived1 se inherit hue h.
            Derived2 obj = new Derived2();
            obj.show();
            obj.show1();
            obj.show2();


            // if i created Derived1 object 
            Derived1 derived1 = new Derived1();
            derived1.show();
            derived1.show1();
            // derived1.show3(); // error kyoki object derived1 class ka h.

            Console.ReadKey();
        }
    }
}
