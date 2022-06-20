using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format_exception
{
    // Exception means -- > error  
    // if exception aati h to hamara program end ho jata h becausse by default C# ka default mackenizm call ho jata h.
    // to ham ye cahte h ki agar exception aa jaye par fir bhi hamara program end ho ho .
    // to iske liye ham catch block ka use karege.

    class MyClass { 
    
        public void show()
        {
           
           string number = Console.ReadLine();
           Console.WriteLine("Entered value "+number);
           Console.WriteLine(number.GetType());

            // if i want to change this number to integer than waht.
            //int ConvertedNumber = int.Parse(number);
            //Console.WriteLine(ConvertedNumber);
            //Console.WriteLine(ConvertedNumber.GetType());

            // abhi tak to theek but if user me "jvdhvfsd" ye input kiya to kese convert hoga..


            //int ConvertedNumber = int.Parse(number);

            // FormatException exception aati h.

            try
            {
                int ConvertedNumber = int.Parse(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Handled");
                Console.WriteLine(ex.Message);
            }
        }
    }

    
    internal class Program {   
              
        
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.show();
            Console.ReadKey();
        }
    }
}
