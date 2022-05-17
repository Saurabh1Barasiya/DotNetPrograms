using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace About_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello";
            Console.WriteLine(greeting);

            //string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //Console.WriteLine("The length of the txt string is: " + txt.Length);

            string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt.ToLower());   // Outputs "hello world"


            //string firstName = "John ";
            //string lastName = "Doe";
            //string name = firstName + lastName;
            //Console.WriteLine(name);



            string firstName = "John ";
            string lastName = "Doe";
            string name = string.Concat(firstName, lastName);
            Console.WriteLine(name);


            string name1 = "Saurabh";
            Console.WriteLine(name1.IndexOf('S')); // if you want index of perticular value index.

            string name2 = "hello my name saurabh";
            Console.WriteLine(name2.EndsWith("h"));
            Console.WriteLine(name2.StartsWith("hello"));
            

            Console.ReadKey();
        }
    }
}
