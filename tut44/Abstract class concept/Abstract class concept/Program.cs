using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_concept
{
    // abstract class ka object nahi babna sakte.
    // if hamne kisi class me abstract method banaya h to hamko us class ko abstract banana padega.
    // abstract class ke ander ham normal method and abstract method bhi bana sakte h.
    abstract class Person
    {
        public string  Firstname { get; set; }
        public string  Lastname { get; set; }
        public int  Age { get; set; }
        public string  Address { get; set; }
        public abstract void Showdetails();
    }


    class Student : Person
    {
        public int Rollno { get; set; }
        public int Fees { get; set; }
        public override void Showdetails()
        {
            Console.WriteLine($"Student name {this.Firstname + " " + this.Lastname}");
            Console.WriteLine($"Student Age {this.Age}");
            Console.WriteLine($"Student Address {this.Address}");
            Console.WriteLine($"Student Rollno {this.Rollno}");
            Console.WriteLine($"Student Fees {this.Fees}");
        }
    }

    class Teacher : Person
    {
        public int TeacherNo { get; set; }
        public int Salary { get; set; }
        
        public override void Showdetails()
        {
            Console.WriteLine($"Teacher name {this.Firstname + " " + this.Lastname}");
            Console.WriteLine($"Teacher Age {this.Age}");
            Console.WriteLine($"Teacher Address {this.Address}");
            Console.WriteLine($"Teacher TeacherNo {this.TeacherNo}");
            Console.WriteLine($"Teacher Salary {this.Salary}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student aman = new Student();
            aman.Rollno = 101;
            aman.Fees = 5000;
            aman.Age = 22;
            aman.Firstname = "Aman";
            aman.Lastname = "Sahu";
            aman.Address = "Harrai";
            aman.Showdetails();

            Console.WriteLine("--------- Teacher Details -----------------");
            Teacher Ranu = new Teacher();
            Ranu.TeacherNo = 501;
            Ranu.Salary = 25000;
            Ranu.Age = 30;
            Ranu.Firstname = "Ranu";
            Ranu.Lastname = "Sahu";
            Ranu.Address = "Jabalpur";
            Ranu.Showdetails();
            Console.ReadKey();
        }
    }
}
