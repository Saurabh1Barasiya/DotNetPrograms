using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (5 > 10)
            {
                Console.WriteLine("lesser");
            }
            else
            {
                Console.WriteLine("Greater");
            }


            int num = 7;
            if (num == 1)
            {
                Console.WriteLine("case 1");
            }
            else if (num == 2)
            {
                Console.WriteLine("case 2");
            }
            else if(num == 3)
            {
                Console.WriteLine("case 3");
            }
            else if (num == 4)
            {
                Console.WriteLine("Case 4");
            }
            else if(num == 5)
            {
                Console.WriteLine("Case 5");
            }
            else
            {
                Console.WriteLine("default value");
            }

            Console.ReadLine();
        }
    }
}
