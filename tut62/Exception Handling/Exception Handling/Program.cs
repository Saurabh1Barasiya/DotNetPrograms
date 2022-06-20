using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    public class CheckException1
    {
        int first;
        int second;

        public void take_input()
        {
            first = int.Parse(Console.ReadLine());
            second = int.Parse(Console.ReadLine());
            try
            {
                int ans = first / second;
                Console.WriteLine("answer"+ans);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occour");
                Console.WriteLine(ex.Message);

            }

            Console.WriteLine("Function task finished");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckException1 obj = new CheckException1();
            obj.take_input();
            Console.ReadKey();
        }
    }
}
