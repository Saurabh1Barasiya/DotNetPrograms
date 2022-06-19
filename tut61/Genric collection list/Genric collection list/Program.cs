using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genric_collection_list
{
    class Emplyee
    {
        public int ID;
        public string Name;
        public string Address;
        public double Salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Emplyee emplyee1 = new Emplyee();
            emplyee1.ID = 1;
            emplyee1.Name = "Amit";
            emplyee1.Address = "Harrai";
            emplyee1.Salary = 5323.012;

            Emplyee emplyee2 = new Emplyee()
            {
                ID = 2,
                Name = "Ranu",
                Address = "Narshingpur",
                Salary = 1231.00,
            };

            Emplyee emplyee3 = new Emplyee()
            {
                ID = 3,
                Name = "Raman",
                Address = "Chhindwara",
                Salary = 12543.023,
            };

            Emplyee emplyee4 = new Emplyee();
            emplyee4.ID = 4;
            emplyee4.Name = "Sachin";
            emplyee4.Address = "Mumbai";
            emplyee4.Salary = 45687.02;

            // store object in a List.
            List<Emplyee> emplist = new List<Emplyee>();
            emplist.Add(emplyee1);
            emplist.Add(emplyee2);
            emplist.Add(emplyee3);
            emplist.Add(emplyee4);


            foreach (Emplyee item in emplist)
            {
                Console.WriteLine("EMployee ID " +item.ID);
                Console.WriteLine("EMployee Name " + item.Name);
                Console.WriteLine("EMployee Address " + item.Address);
                Console.WriteLine("EMployee Salary " + item.Salary);

                Console.WriteLine("------------------------------------------");
            }


            Console.WriteLine(emplist.Capacity);

            //emplist.Remove(emplyee4);


            foreach (Emplyee item in emplist)
            {
                Console.WriteLine("EMployee ID " + item.ID);
                Console.WriteLine("EMployee Name " + item.Name);
                Console.WriteLine("EMployee Address " + item.Address);
                Console.WriteLine("EMployee Salary " + item.Salary);

                Console.WriteLine("------------------------------------------");
            }

            // ham aesa isiliye likh paye ki Find function 1 predicate leta h.
            Emplyee getThree = emplist.Find(emp => emp.ID == 3);
            Console.WriteLine("Id "+getThree.ID); 
            Console.WriteLine("Name "+getThree.Name); 
            Console.WriteLine("Address "+getThree.Address); 
            Console.WriteLine("Salary "+getThree.Salary);



            Console.WriteLine(emplist.FindIndex(1, emp => emp.ID == 3));

            /*
            emplist.RemoveAt(2);
            foreach (Emplyee item in emplist)
            {
                Console.WriteLine("EMployee ID " + item.ID);
                Console.WriteLine("EMployee Name " + item.Name);
                Console.WriteLine("EMployee Address " + item.Address);
                Console.WriteLine("EMployee Salary " + item.Salary);

                Console.WriteLine("------------------------------------------");
            }
            */

            emplist.RemoveAll(emp => emp.ID == 4);

            foreach (Emplyee item in emplist)
            {
                Console.WriteLine("EMployee ID " + item.ID);
                Console.WriteLine("EMployee Name " + item.Name);
                Console.WriteLine("EMployee Address " + item.Address);
                Console.WriteLine("EMployee Salary " + item.Salary);

                Console.WriteLine("------------------------------------------");
            }
            Console.ReadKey();
        }
    }
}
