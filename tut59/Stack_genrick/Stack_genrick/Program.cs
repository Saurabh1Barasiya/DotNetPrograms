using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_genrick
{
    // using System.Collections.Generic; must import this.
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> obj = new Stack<int>();
            obj.Push(1);    
            obj.Push(2);
            obj.Push(3);
            obj.Push(4);
            obj.Push(5);
            obj.Push(6);
            //obj.Push("fbf"); can't insert because stack is integer type.


            // Stack works in lifo List in First Out .


            foreach (int item in obj)
            {
                Console.WriteLine(item);
            }


            Stack<string> names = new Stack<string>();
            names.Push("Tiya");
            names.Push("Piya");
            names.Push("Jiya");
            names.Push("Piya");
            names.Push("Riya");

            Console.WriteLine("Totel number of element "+names.Count);
            Console.WriteLine("Jiya is present " + names.Contains("Jiya"));
            Console.WriteLine("Janu is present " + names.Contains("Janu"));

            

            Console.WriteLine("Get top element "+names.Peek());
            string PoppedValue =names.Pop();
            Console.WriteLine("Popped value is "+PoppedValue);

            Console.WriteLine("Get top element " + names.Peek());

            
            Console.ReadKey();
        }
    }
}
