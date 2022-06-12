using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_expression
{
    // we always we use ananamous function with delegates.
    // lambda experssion is a easyiest version of ananamous function.
    // delegate ka use to hamko karna hi padega.


    // lambda expression are two type .
    // experssion and statement.
    // expression by default value return karta h.
    // statement by default value return nahi karta.

    public delegate void Mydelagate(int a);
    public delegate int MydelAdd(int a,int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            // yaha lambda expression ka use hua h.
            MydelAdd obj = (a, b) => a + b;
            Console.WriteLine(obj.Invoke(5, 5));

            Mydelagate obj1 = (number) =>
            {

                // ye lambda statement h. ye by default value return nahi karta.
                number += 10;
                Console.WriteLine(number);
            };
            obj1.Invoke(5);
            Console.ReadKey();
        }
    }
}
