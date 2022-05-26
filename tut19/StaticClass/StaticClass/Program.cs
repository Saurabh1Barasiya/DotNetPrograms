using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    // Here welearn about Static class.

    static class Product
    {
        // we can not create object of static class.
        // we can not create child class with the help of static class.
        // static class contain only static method and menbers.
        // object (instance) se related koi bhi kaam nahi hoga.

        // int  productID; aesa bhi bahi kar sakte .. static likhna hi padega.

        public static int pid;
        public static string pname;
        public static int pprice;

        static Product()
        {
            pid = 1;
            pname = "mobile";
            pprice = 10000;
        }

        //public void Getdata()
        //{
        //    // we cannot make instance method inside static class.
        //}

        public static void GetData()
        {
            Console.WriteLine($"PID is {pid}");
            Console.WriteLine($"Pname is {pname}");
            Console.WriteLine($"Pprice is {pprice}");
        }


        public static void Discount()
        {
            int d = 500;
            pprice -= d;
            Console.WriteLine($"After discount the original price is {pprice}");
        }



    }

    //class NewProduct : Product
    //{
    //    // we can not create child class with the help of static class.
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            // we can not create object of static class.
            // Product product = new Product();

            Product.GetData();
            Product.Discount();
            Console.ReadKey();
        }
    }
}
