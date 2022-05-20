using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_value_and_out
{
    internal class Program
    {

        public static void Add(int first, int secound)
        {
            Console.WriteLine(first + secound);
        }

        public static void changebyref(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        public static void GetVal(out int a)
        {
            // Pass by out

            // yaha hamko initilize value send karne ki need nahi h.
            a = 15;
        }


        static void Main(string[] args)
        {

            //Pass by value
            int a = 1;
            int b = 2;
            Program.Add(a, b);

            // Pass by reference ref keyword.

            // When we use ref keyword to argument send karne se pahle unka inilizie hona jaruri h.
            Program.changebyref(ref a,ref b);


            
            
            Console.WriteLine($"Value of a is {a} and b is {b}");

            // pass by out
            int f1;
            Program.GetVal(out f1);
            Console.WriteLine($"After calling tha pass by out method value of f1 {f1}");

            Console.ReadKey();
        }
    }
}
