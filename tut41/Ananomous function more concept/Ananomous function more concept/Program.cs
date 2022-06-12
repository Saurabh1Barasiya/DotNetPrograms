using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ananomous_function_more_concept
{
    public delegate void MyDelegate(int a);
    internal class Program
    {
        public static void CallDelegate(MyDelegate del,int a)
        {
            a++;
            del(a);

        }
        static void Main(string[] args)
        {
            Program.CallDelegate(delegate(int b){
                b = b + 10;
                Console.WriteLine(b);
            },5);
            Console.ReadKey();
        }
    }
}
