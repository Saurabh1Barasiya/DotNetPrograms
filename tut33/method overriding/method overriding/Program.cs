using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overriding
{

    // In overriding we use virtual and override keyword.
    // Parent class me bhi same method and child class me bhi same method to ye inheritance h.
    class Parent
    {
        /*
        public void show()
        {
            Console.WriteLine("I am Parent class method");
        }

        public void show1()
        {
            Console.WriteLine("I am Parent class show 1 method");
        }
        */

        public virtual void show()
        {
            Console.WriteLine("I am Parent class method");
        }

    }

    class Child : Parent
    {
        /*
        public new void show()
        {
            Console.WriteLine("I am child class method");
        }
        */
        public override void show()
        {
            Console.WriteLine("I am Child class method");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Parent parent = new Parent();
            // is case me object parent class ka h to method bhi parent class ka hi run hoga.
            parent.show();

            Child child = new Child();
            child.show();
            // is case me object Child class ka h to method bhi Child class ka hi run hoga.



           // ab kon sa chalega.
           Parent obj = new Child();
           obj.show();
           // Abhi bhi parent wala hi run hoga.
           obj.show1();
           
           // ye latest call se ye samaj me aa raha h reference jis type ka hoga usi class ka method run hoga.
           */

            Child child = new Child();
            child.show();


           Console.ReadKey();
        }
    }
}
