using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace about_queeue
{
    internal class Program
    {
        // Queue works as fifo style.
        // First in first out.
        static void Main(string[] args)
        {
           Queue obj = new Queue();
           obj.Enqueue("one");
           obj.Enqueue("two");
           obj.Enqueue("three");
           obj.Enqueue("four");

           foreach (var item in obj)
           {
              Console.Write(item);
           }

           Console.WriteLine();
           Console.WriteLine("First item "+obj.Dequeue()); 
           Console.WriteLine("Secound item "+obj.Dequeue()); 
           Console.WriteLine("Third item "+obj.Dequeue()); 
           Console.WriteLine("Forth item "+obj.Dequeue()); 


           Console.ReadKey();
           
           // 
        }
    }
}
