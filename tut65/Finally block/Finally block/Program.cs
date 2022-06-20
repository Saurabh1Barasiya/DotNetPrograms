using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finally_block
{

    class ExceptionFinally
    {
        public void show() {
            int a = 10;
            int b = 0;
            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally har hall me chanle ki garrenty deta h.");
            }
        }
        

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ExceptionFinally obj = new ExceptionFinally();
            obj.show();
            Console.ReadKey();
        }
    }
}
