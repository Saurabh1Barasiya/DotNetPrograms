using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_implemented_properties
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Id = 1;
            student.Name = "saurabh";
            student.Age = 23;
            student.Address = "Harrai";

            Console.WriteLine(student.Id);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.Address);

            Console.ReadKey();
        }
    }
}
