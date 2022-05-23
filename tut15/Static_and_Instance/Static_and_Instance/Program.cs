using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_and_Instance
{
    class Student
    {
        int ID;
        string FirstName;
        string LastName;
        string Address;
        public static int sal = 123;

        public Student(int id,string firstname,string lastname,string address)
        {
            this.ID = id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Address = address;
            // this.sal = 45; static variable ko  ham yaha access nahi kar sakte.
        }
        public static void greet()
        {
            Console.WriteLine($"Welcome to this program  salary is {Student.sal}");
            // this.sal; ham yaha object(instance) ko access nahi kar sakte.

        }
        public void display()
        {
            Console.WriteLine(this.ID);
            Console.WriteLine(this.FirstName);
            Console.WriteLine(this.LastName);
            Console.WriteLine(this.Address);

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student(1,"Saurabh","Barasiya","Harrai");
            // obj.greet(); 👀👀👀👀👀👀👀👀👀👀👀👀👀.
            // ham instance (obj) se static method ko call nahi kar sakta.
            // ham class ka use karke call karege Student.greet().

            Student.greet();
            obj.display();
            Console.ReadKey();
        }
    }
}
