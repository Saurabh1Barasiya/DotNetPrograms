using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_about_genric
{
    class MygenricClass<UnknowData>
    {
        public UnknowData Check(UnknowData a, UnknowData b)
        {
            if (a.Equals(b))
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MygenricClass<int> mygenricClass = new MygenricClass<int>();
            Console.WriteLine(mygenricClass.Check(5,5));
            Console.ReadKey();
        }
    }
}
