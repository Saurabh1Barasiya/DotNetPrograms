using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genric_methods
{
    internal class Program
    {
       // public static void ShowArray(int[] arr)
       // {
            // to ham yaha string ya koi other data nahi le sakte because hamne parameter ko int type ka banaya h.
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            // but if ham genric ka use kare to ham any type of data ko handle kar sakte h.

       // }

        // <> ke ander koi value likhte h and us value ko datatype ki jagah likh dete h.
        public static void ShowArray<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
        public static bool Istrue<T>(T a,T b)
        {
            bool c = a.Equals(b);
            return c;
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;
            Program.ShowArray(numbers);
            string[] names = {"aman","rahul","amit","talu","palu"};
            Program.ShowArray(names);
            double[] doubleData = { 12.03, 1253.0, 456.0, 6458.00, 45.215, 1236.0236 };
            Program.ShowArray(doubleData);

            Console.WriteLine(Program.Istrue("bcbfj","dbjs")); 
            Console.ReadKey();
        }
    }
}
