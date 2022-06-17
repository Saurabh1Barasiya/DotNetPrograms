using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Example_of_arraylist
{
    internal class Program
    {
        // Arraylist is a dynamic ,it contain multiple data types ,it can be  grow and shrink.
        // while array is a fixedsize.
        static void Main(string[] args)
        {
            ArrayList myArr1 = new ArrayList(20);
            Console.WriteLine("Initial size "+myArr1.Capacity);
            ArrayList myArr = new ArrayList();

            Console.WriteLine($"initial capacity {myArr.Capacity}");
            myArr.Add(10);
            myArr.Add(20);
            myArr.Add(30);
            myArr.Add(40);
            Console.WriteLine($"now capacity {myArr.Capacity}");
            foreach (int item in myArr)
            {
                Console.Write(item+" ");
            }
            myArr.Add("sanu");
            myArr.Add("tanu");
            myArr.Add("panu");
            myArr.Add("janu");
            myArr.Add("janu");
            foreach (var item in myArr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"now capacity {myArr.Capacity}");
            Console.ReadLine();
        }
    }
}
