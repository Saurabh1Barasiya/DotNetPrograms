using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_constructor
{
    class Student
    {
        public static string greet;

        public static int gold;

        //👀👀👀👀👀👀👀👀👀👀
        // static constructor only 1 hi baar call hota by CLR . matlab Clr khud ki static constructor ko call karta h.
        // Object banne ke pahle static constructor call hota h.
        // Instance constructor har object ke liye call hota h .
        // static constructor har object ke liye call nahi hota.
        static Student()
        {
            greet = "Hello i am Static variable";
            gold = 56;
            Console.WriteLine("Static constructor invoked ");
        }

        public Student()
        {
            Console.WriteLine("Public constructor invoked");

            // ham static value ko yaha access kar sakte h.
            Console.WriteLine("Value of static variable "+gold);
        }

        public void Display()
        {
            // Ham static value ko instance method ke ander access kar sakte h.
            // But instance value ko static method ke ander access nahi kar sakte.
            Console.WriteLine(greet);
            Console.WriteLine(Student.gold);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Student student1 = new Student();
            Student student2 = new Student();
            student1.Display();

            //Student.greet = "Assign value from outside";
            //Student.gold = 456;

            //student2.Display();
            Console.ReadKey();
        }
    }
}




