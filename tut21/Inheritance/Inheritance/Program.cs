using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    class Employee
    {
        // By Default thease variables are private . and private variavle inherit nahi hote.
        // so hamne isko public bana diya.
        // in c# (:) -- > means inheritance.
        public int ID;
        public string Name;
        public string address;

        //public Employee(int id,string name,string address)
        //{
        //   this.ID = id;
        //   this.Name = name;
        //   this.address = address;
        //}
        
        public void Display()
        {
            Console.WriteLine($"ID is {this.ID}");
            Console.WriteLine($"Name is {this.Name}");
            Console.WriteLine($"Address is {this.address}");
        }

    }

    class PermanentEmployee : Employee
    {
        // Single Inheritance 


        public int salary;
        public int workingHours;



        public new void Display()
        {
            // yaha new nahi likege to bhi chalega.
            // muje yaha new ke bare ke nahi pata h.

            Console.WriteLine($"ID is {this.ID}");
            Console.WriteLine($"Name is {this.Name}");
            Console.WriteLine($"Address is {this.address}");
            Console.WriteLine($"Salary is {this.salary}");
            Console.WriteLine($"WorkingHours is {this.workingHours}");
        }

    }

    class ParttimeEmployee : PermanentEmployee
    {
        // Multilevel Inheritance ...

        public ParttimeEmployee()
        {
            this.salary = 10000;
            this.workingHours = 5;
        }

        public new void Display()
        {
            // yaha new nahi likege to bhi chalega.
            // muje yaha new ke bare ke nahi pata h.

            Console.WriteLine($"ID is {this.ID}");
            Console.WriteLine($"Name is {this.Name}");
            Console.WriteLine($"Address is {this.address}");
            Console.WriteLine($"Salary is {this.salary}");
            Console.WriteLine($"WorkingHours is {this.workingHours}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.ID = 1;
            emp.Name = "Saurabh";
            emp.address = "Chhindwara";
            //Console.WriteLine(emp);  //outpput --> Inheritance.Employee 
            emp.Display();

            Console.WriteLine("========================================");

            PermanentEmployee emp1 = new PermanentEmployee();
            emp1.ID = 5;
            emp1.Name = "Peeyush";
            emp1.address = "Harrai";
            emp1.salary = 50000;
            emp1.workingHours = 10;
            emp1.Display();


            Console.WriteLine("========================================");

            ParttimeEmployee emp2 = new ParttimeEmployee();
            emp2.ID = 6;
            emp2.Name = "Ranu";
            emp2.address = "Narshingpur";
            emp2.Display();
            

            Console.ReadKey();
        }
    }
}
