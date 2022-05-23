using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace About_class
{
    class Student
    {
        // in c# if ham koi bhi access spesifier/modifier nahi dete h to vo by default priivate hota h.
        int sid;
        string sname;
        int sage;
        string address;

        public Student(int sid,string sname,int sage , string address)
        {
            Console.WriteLine("Constructor invoked");
            this.sid = sid;
            this.sname = sname;
            this.sage = sage;
            this.address = address;
        }

        public void Display()
        {
            Console.WriteLine($"Student id {this.sid} name {this.sname} age {this.sage} address {this.address}");

            Console.WriteLine("Student id"+this.sid);
            Console.WriteLine("Student name" + this.sname.ToUpper());
            Console.WriteLine("Student age" + this.sage);
            Console.WriteLine("Student address" + this.address);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student(1,"saurabh",22,"Chhindwara");
            //obj.sid = 1; //because its private 
            obj.Display();
            Console.ReadKey();
        }
    }
}
