using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoimplemented_properties_more
{
    class Student
    {
        
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Address { get; private set; }


        public Student(int id ,string name,int age,string address)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Address = address;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student obj = new Student();
            //👀👀👀👀👀👀👀👀👀👀👀👀👀👀👀👀👀👀👀👀👀👀👀👀
            // ab aese access nahi kar sakte.

            //obj.Id = 1;
            //obj.Name = "amit";
            //obj.Age = 22;
            //obj.Address = "Harrai";

            // ab ham class ke bahar se direct access nahi kar sakte.

            Student obj = new Student(2, "ranu", 22, "narshingpur");

            Console.WriteLine(obj.Id);
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Age);
            Console.WriteLine(obj.Address);
            Console.ReadKey();
        }
    }
}
