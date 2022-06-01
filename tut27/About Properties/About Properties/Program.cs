using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace About_Properties
{
    // Here we learn about properties.
    // basacilly it is a way to archive encapsulation.
    // we use four types of properties.

    // set
    // get
    // set only 
    // get only
    // auto implemented

    // with the help of properties we acess private variables.

    // integer ke case ---> if value set nahi hoti h or ham usko get karte h to hamko 0 milta h.
    // string ke case ---> if value set nahi hoti h or ham usko get karte h to hamko '' empty or null milta h.

    class Student
    {
        private int id;
        private string name;
        private int age;
        private string address;

        // apply properties

        /*
        public int Id
        {
            //In properties we have two methods -- > set and get
            // with the help of set we set the value.
            // and get return the value.
            set { id = value; }
            get { return id; }
        }
        */

        // if you want to apply some validation, so hacken can not acess thease use thease variables.

        public int Id
        {

            set {
                if (value > 0)
                {
                    this.id = value;   
                }
                else
                {
                    Console.WriteLine("Id can not be negattive or zero");
                }
            }
            get { return this.id; }
        }

        public string Name
        {

            set
            {
                if (value.Length > 4)
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine("Name shoiud greater than 4 digit");
                }
            }
            get { return this.name; }
        }

        public int Age
        {
            set
            {
                if (value > 0)
                {
                    this.age = value;
                }
                else
                {
                    Console.WriteLine("you are not exist in this world");
                }
            }
            get
            {
                if (this.age == 0)
                {
                    return -1;
                }
                else
                {
                    return this.age;
                }
                
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            //student.Id = 1;
            // Console.WriteLine(student.Id);

            student.Id = -445454;
            Console.WriteLine(student.Id);

            student.Name = "sa";
            Console.WriteLine(student.Name);
            Console.WriteLine(String.IsNullOrEmpty(student.Name));

            student.Age = -12;
            Console.WriteLine(student.Age);
            Console.ReadKey();

        }
    }
}
