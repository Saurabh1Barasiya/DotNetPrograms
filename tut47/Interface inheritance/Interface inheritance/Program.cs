using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_inheritance
{
    interface I1
    {
        void print1();
    }

    interface I2
    {
        void print2();
    }

    interface I3 : I1, I2
    {
        void print3();
    }
    internal class Program :  I3
    {
        public void print1()
        {
            Console.WriteLine("Interface 1 method");
        }

        public void print2()
        {
            Console.WriteLine("Interface 2 method");
        }

        public void print3()
        {
            Console.WriteLine("Interface 3 method");
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.print1();
            obj.print2();
            obj.print3();


            //I1 i3 = Program();
            //i3.
            Console.ReadKey();
        }
    }
}
