using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_on_properties
{
    // make only setter
    class Student
    {
        // its only read only
        private int max_marks;
        private string name;
        public int MaxMarks
        {
            get
            {
                return this.max_marks;
            }
        }

        public string Name
        {
            // so ham only set kiye h get nahi.
           set
           {
                this.name = value;
           }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            // student.MaxMarks = 12;
            // so here ham value ko only get kar ksate h set ni.
            student.Name = "aman";
            // Console.WriteLine(student.Name); // ham get nahi kar sakte.
        }
    }
}
