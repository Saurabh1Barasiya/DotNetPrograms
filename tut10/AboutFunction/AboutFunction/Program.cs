using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutFunction
{
    internal class Program
    {
        static void greet()
        {
            Console.WriteLine("Hello wellcome to learn function");
            Console.WriteLine("I am static function");
        }

        public void add()
        {
            Console.WriteLine("I am a Add function");
            Console.WriteLine("I am a Instance method");
        }


        public int sub(int first, int secound)
        {
            return first - secound;
        }



        public void namedOrg(string name,int age)
        {
            Console.WriteLine($"Name is {name} and age is {age}");
        }

        static void Main(string[] args)
        {
            //here we see two type of method -> Static and Instance.
            //when we work about instance so we create a object .
            //and when we work on static so no need to create a object.
            greet();
            Program obj = new Program();
            obj.add();
            Console.WriteLine(obj.sub(1, 2));

            //obj.namedOrg("saurabh", 22);
            // obj.namedOrg(22,"saurabh"); // It gives error . so we use named argument concept.

            obj.namedOrg(age:22,name:"saurabh");

            Console.ReadKey();
            
        }
    }
}
