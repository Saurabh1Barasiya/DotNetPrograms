using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{

    class Student
    {
        //public int age;
        //public string name;


        // by default private hota h.
         int age;
         string name;

        // setter
        public void SetAge(int age)
        {
            if (age < 0)
            {
                Console.WriteLine("Can can not be 0 or less then 0");
            }
            else
            {
                this.age = age;
            }
        }

        // getter
        public int GetAge()
        {
            return this.age;
        }


        // setter for name
        public void Setname(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                // check name empty or null to nahi h.
                Console.WriteLine("Name can not null or empty");
            }
            else
            {
                this.name = name;
            }
        }

        // getter for name
        public string Getname()
        {
            return this.name;
        }
    }


    // class ya to public hogi ya internal.
    internal class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student();

            // if encapsulation ka use nahi karege to koi bhi in fields me value set kar dega.
            // wrapping the variable and methods inside a class is know as encapsulation.

            // to ham aesa nahi karege
            //obj.age = 1;
            //obj.name = "eaju";

            // ham banayege setter and getter and filed ko private kar dege.
            obj.Setname("toy");
            obj.SetAge(10);
            Console.WriteLine(obj.GetAge());
            Console.WriteLine(obj.Getname());
            Console.ReadKey();
        }
    }
}
