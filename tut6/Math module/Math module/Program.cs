using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine(Math.Min(a, b));
            Console.WriteLine(Math.Max(a, b));
            Console.WriteLine(Math.Abs(-45));
            Console.WriteLine(Math.Pow(2,3));
            Console.WriteLine(Math.Ceiling(3.9)); // Ceil means top
            Console.WriteLine(Math.Floor(3.9));  // flor means down
            Console.ReadKey();
        }
    }
}
