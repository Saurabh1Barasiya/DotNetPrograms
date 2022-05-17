using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
     public class Program
     {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            Console.WriteLine(a + b);
            Console.WriteLine($"Addtion is {a + b}");
            Console.WriteLine($"Substration is {a - b}");
            Console.WriteLine($"Multiplaction is {a * b}");
            Console.WriteLine($"Division is {a / b}");
            Console.ReadKey();
        }
    }
}
