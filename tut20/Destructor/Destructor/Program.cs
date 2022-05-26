using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{

    // 👀👀👀👀👀👀👀👀👀👀👀👀👀
    // Destructor has same name as class but its starts with ~ (tild) sign.
    // When our program is going to finish destructor is going to run.
    // Destructor has no access specifier or modifier.

    class Person
    {
        int id;
        int age;
        string name; 

        // by default thease are private.

        public Person()
        {
            this .id = 1;
            this .age = 24;
            this.name = "Saurabh";
        }

        public int GetId()
        {
            return this .id;
        }

        public int Getage()
        {
            return this.age;

        }

        public string GetName()
        {
            return this.name;
        }

        ~Person()
        {
            // This is Destructor.
            // Destructor invoked.......
            Console.WriteLine("Destructor Invoked");

            // If we have multiple object so Destructor runs multiple time.
            // matlab jitne object hoge utne hi time Destructor run hoga.
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.GetId());
            Console.WriteLine(person.Getage());
            Console.WriteLine(person.GetName());

            Person person1 = new Person();
            Console.WriteLine(person1.GetId());
            Console.WriteLine(person1.Getage());
            Console.WriteLine(person1.GetName());

            // if you want to see destructor run so press ctrl+f5.


            //Console.ReadKey();
        }
    }
}
