using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace About_stack
{
    
    internal class Program
    {

        // parivartan hi paridaam dega.

        // stack work in lifo --> List In first out
        // jo last me aayega vo sabse pahle jayega.



        // push -- > insert.
        // pop --> delete.
        // peek -- > retrive.

        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20); 
            stack.Push("saurabh");
            stack.Push("ranu");

            Console.WriteLine(stack.Peek());

            var val = stack.Pop();
            Console.WriteLine("Poped value "+val);
            Console.WriteLine("--------------------");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("number of count "+ stack.Count);

            stack.Clear();

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Stack is empty");
            Console.ReadKey();


        }
        // 10 -> 20 -> saurabh -> ranu
        
    }
}
