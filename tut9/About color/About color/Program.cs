using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace About_color
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Understanding Console Class";
            Console.WriteLine("BackgroundColor Blue");
            Console.WriteLine("ForegroundColor White");
            Console.WriteLine("Title Understanding Console Class");
            Console.ReadKey();
        }
    }
}
