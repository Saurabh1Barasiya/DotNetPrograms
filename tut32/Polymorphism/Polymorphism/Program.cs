using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Student
    {
        // poly means -- many
        // morpshism -- types

        // function name is same but diffrence in argument.
        // same funcion with no argument.
        // same function with 1 int argument.
        // same function with 2 int argument
        // same function with 2 sring  argument.
        // same function with 1 int and 1 string argument.


        // when binding happens at compile time so its none as static or early binding.
        // when binding happens at run time so its none as dynamicor late binding.

        // yaha ham log return type ko exclude karte h.

        public void Add()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            Console.WriteLine($"Value of c {c}");
        }

        public void Add(int a , int b)
        {
            int c = a + b;
            Console.WriteLine($"Value of c {c}");
        }



        public void Add(string a, string b)
        {
            string c = a + b;
            Console.WriteLine($"Value of c {c}");
        }


        public void Add(float a, float b)
        {
            float c = a + b;
            Console.WriteLine($"Value of c {c}");
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Add();
            student.Add(2.0f, 3.0f);
            student.Add(1,1);
            student.Add("amman ","khan");
            Console.ReadKey();
        }
    }
}
