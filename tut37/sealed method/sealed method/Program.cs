using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_method
{

    class Parent
    {
        public virtual void Show()
        {
            Console.WriteLine("This is parent class method");
        }
    }

    class Child : Parent
    {
        public sealed override void Show()
        {
            // ab hamne yaha Show() method ko sealed keyword ka use kiya h to ab further ham Show ko override nahi kar sakte.
            Console.WriteLine("This is Clild class method");
        }
    }

    /*
    class SubChild : Child
    {
        // hane upar sealed ka use kiya hu to ham show ko override nahi kar sakte.
        public override void Show()
        {
            // ab hamne yaha Show() method ko sealed keyword ka use kiya h to ab further ham Show ko override nahi kar sakte.
            Console.WriteLine("This is Clild class method");
        }
    }
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Show();
            Console.ReadKey();
        }
    }
}
