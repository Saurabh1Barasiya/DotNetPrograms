using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void Calculation(int first, int secound);
    internal class Program
    {
        public static void Addtion(int a, int b)
        {
            int c = a + b;
            Console.WriteLine($"Result of this addtion is {c}");
        }
        public static void Subtraction(int a, int b)
        {
            int c = a - b;
            Console.WriteLine($"Result of this Subtraction is {c}");
        }
        public static void Multiplaction(int a, int b)
        {
            int c = a * b;
            Console.WriteLine($"Result of this Multiplaction is {c}");
        }
        public static void Division(int a, int b)
        {
            int c = a / b;
            Console.WriteLine($"Result of this Division is {c}");
        }

        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Program.Addtion);
            obj.Invoke(5, 5);
            Calculation obj1 = new Calculation(Program.Subtraction);
            obj1.Invoke(5, 5);
            Calculation obj2 = new Calculation(Program.Multiplaction);
            obj2.Invoke(5, 5);
            Calculation obj3 = new Calculation(Program.Division);
            obj3.Invoke(5, 5);
            Console.ReadKey();
        }
    }
}
