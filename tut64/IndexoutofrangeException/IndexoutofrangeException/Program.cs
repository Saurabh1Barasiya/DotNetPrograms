using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexoutofrangeException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IndexOutOfRangeException

            //int[] arr = new int[5];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //arr[3] = 4;
            //arr[4] = 5;
            //arr[5] = 6;
            //arr[6] = 7;

            int[] arr = new int[5];
            try
            {
                arr[0] = 1;
                arr[1] = 2;
                arr[2] = 3;
                arr[3] = 4;
                arr[4] = 5;
                arr[5] = 6;
                arr[6] = 7;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Exception handled");
                Console.WriteLine("Bhaiya jitni limit h utna hi store kero jyadha nahi .");
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
