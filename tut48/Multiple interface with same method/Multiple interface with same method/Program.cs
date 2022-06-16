using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_interface_with_same_method
{

    // jab hamare paas 2 interface me same method h to ham to ham isko explicit implement karege.
    interface I1
    {
        void show();
    }
    interface I2
    {
        void show();
    }
    class Test : I1, I2
    {
        void I1.show()
        {
            Console.WriteLine("Interface I1 methods called");
        }

        void I2.show()
        {
            Console.WriteLine("Interface I2 methods called");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test(); 
            ((I1)test).show();
            ((I2)test).show();

            Console.WriteLine("-------------------------------------");
            I1 t1 = new Test();  // ((I1)test).show();  
            t1.show();
            Console.ReadKey();
        }
    }
}
