using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First Name");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            string lname = Console.ReadLine();

            Console.WriteLine($"First name {fname} and last name {lname}");




            // how to take integer number as a input.
            Console.WriteLine("Enter a Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a.GetType());

            Console.WriteLine("Enter a secound Number");
            int b = int.Parse(Console.ReadLine());

            int c = a + b;
            Console.WriteLine($"The addtion is {a + b}");

            // float input
            Console.WriteLine("Enter a amout");
            float amt = float.Parse(Console.ReadLine());
            Console.WriteLine(amt.GetType());


            Console.WriteLine("Checking mode enabled....");


            int n = 34;
            Console.WriteLine(n.GetType());
            string name = "Smome";
            Console.WriteLine(name.GetType());
            Console.ReadKey();
        }
    }
}
