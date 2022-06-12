using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ananamous_methods
{

    //public delegate void AnanamousMethodDelegate(int number);
    public delegate int AnanamousMethodDelegate(int number);
    internal class Program
    {

        // we always use Ananamous function with delegates.
        // Ananamous function ke ander ham koi bhi access modifier ka use nahi karte.
        // Ananamous function me ham koi bhi ref and out keyword ka use nahi karte.


        //public static void Mymethod(int num)
        //{
        //    num += 10;
        //    Console.WriteLine(num);
        //}


        static void Main(string[] args)
        {
            //AnanamousMethodDelegate obj = new AnanamousMethodDelegate(Program.Mymethod);
            //obj.Invoke(5);


            //AnanamousMethodDelegate obj = delegate(int number) { 
            //  number++;
            //  Console.WriteLine(number);
            //};

            //obj.Invoke(10);


            AnanamousMethodDelegate obj = delegate (int number) {
                number++;
                number++;
                return number;
            };

            Console.WriteLine(obj.Invoke(11)); 

            Console.ReadKey();
        }
    }
}
