using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Properties
{
     abstract class Person
     {
        public abstract uint Id { get; set; }
        public abstract string Name { get; set; }
     }

    class Student : Person
    {
        // uint => unsigned int matlab ham isme negative value store nahi kar sakte.
        uint StudentID;
        string StudentName;
        public override uint Id
        {
            get
            {
                 return StudentID;
            }
            set
            {
                this.StudentID = value;
            }
        }

        public override string Name {
            get
            {
                return StudentName;
            }
            set
            {
                this.StudentName = value;
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Student aman = new Student();
            //aman.Id = -10;
            aman.Id = 10;
            aman.Name = "Aman";
            Console.WriteLine(aman.Id);
            Console.WriteLine(aman.Name);
            Console.ReadKey();
        }
    }
}
