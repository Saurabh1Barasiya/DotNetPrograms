using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_constructor
{

    class Student
    {
        // we use copy constructor to copy the value for existing object to new object.

        // copy constructor must take a parameter and the value must be object.

        int id;
        string name;

        public Student(int id,string name)
        {
            this.id = id;
            this.name = name;       
        }

        // Copy Constructor ke pahle 1 Constructor bana rahna chahiye.

        public Student(Student obj)
        {

            // Copy Constructor .
            // copy old object value to new object .
            this.id = obj.id;
            this.name = obj.name;
        }
        public void Display()
        {
            Console.WriteLine("Name is "+this.name);
            Console.WriteLine("Id is "+this.id);
            Console.WriteLine("=====================");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student saurabh = new Student(1,"Saurabh");
            Student peeyush = new Student(saurabh);
            saurabh.Display();
            peeyush.Display();
            Console.ReadKey();
        }
    }
}
