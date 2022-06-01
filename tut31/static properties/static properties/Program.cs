using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_properties
{
    class Student
    {
        public static string Name { get; set; }
        public static int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student.Age = 50;
            Student.Name = "Harshit";

            Console.WriteLine(Student.Age);
            Console.WriteLine(Student.Name);

            Console.ReadKey();
        }
    }
}
