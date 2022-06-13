using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abouut_abstraction
{
    // Abstruction means hiding the implementation and showing only nessery details.
    class Employee
    {
        // by default all member are private.
        private int Empid;
        private string Name;
        private string Address;
        private double salary;
        private double tax = 0.1; // 10% tax.
        private double NetSalary;

        public Employee(int id,string name, string add,double sal)
        {
            this.Empid = id;
            this.Name = name;
            this.Address = add;
            this.salary = sal;
        }
        void CalculateSalary()
        {
            // by default menas private ..
            // isko class ke bahar se call nahi kar sakte.
            if(salary >= 30000)
            {
                NetSalary = salary - (salary * tax);
            }
            else
            {
                NetSalary = salary;
            }
        }

        public void ShowEmployeeDetils()
        {
            Console.WriteLine($"Employee id is {Empid}");
            Console.WriteLine($"Employee Name is {Name}");
            Console.WriteLine($"Employee Address is {Address}");
            CalculateSalary();
            Console.WriteLine($"Employee salary is {NetSalary}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee(1,"Arun","Chhinda",40000.00);
            obj.ShowEmployeeDetils();
            Console.ReadKey();
        }
    }
}
