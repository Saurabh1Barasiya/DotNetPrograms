using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inheritance
{

    // Multiple inheritance  --> base classs are more then one and drived class is single.

    // in c# multiple inheritance is not possibile using class , but yes we archive using interfaces.

    /*
    class A
    {

    }
    class B
    {

    }

    class D : A, B
    {

    }
    */

    interface I1
    {
        void show();
    }

    interface I2
    {
        void show();
    }

    class Devived : I1, I2
    {
        void I1.show()
        {
            Console.WriteLine("function from I1 interface");
        }

        void I2.show()
        {
            Console.WriteLine("function from I2 interface");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Devived devived = new Devived();
            ((I1)devived).show();
            ((I2)devived).show();
            Console.ReadKey();
        }
    }
}
