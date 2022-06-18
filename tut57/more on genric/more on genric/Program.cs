using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_on_genric
{
    public class Employee
    {
        public int ID;
        public string Name;
        public string Address;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // index based generic collection (arraylist)
            /*
            List<int> listObj = new List<int>();
            listObj.Add(123);
            listObj.Add(235);
            */
            // Displaying list value using index
            //Console.WriteLine("List Second Value: {0}", listObj[1]);
            // Key based generic Collection (Dictionary)


            //Dictionary<int, string> objDic = new Dictionary<int, string>();
            //objDic.Add(123, "Ramakrishna");


            // Displaying Dictionary value using Key


            //Console.WriteLine("Dictionary Value: {0}", objDic[123]);


            // Priority based Generic Collection (Stack)


            //Stack<int> objStack = new Stack<int>();
            //objStack.Push(1);
            //objStack.Push(2);
            //objStack.Push(3);


            // Display first value from Stack

            // Console.WriteLine("First Get Value from Stack: {0}", objStack.Pop());


            // Priority based Generic Collection (Queues)

            //Queue<int> objQueue = new Queue<int>();
            //objQueue.Enqueue(1);
            //objQueue.Enqueue(2);
            //objQueue.Enqueue(3);

            // Display first value from Stack

            //Console.WriteLine("First Get Value from Queue: {0}", objQueue.Dequeue());
            //Console.WriteLine();

            // Creating Employee records

            Employee empObj1 = new Employee();
            empObj1.ID = 1001;
            empObj1.Name = "Ramakrishna";
            empObj1.Address = "Hyderabad";

            //Console.WriteLine(empObj1.ID);
            //Console.WriteLine(empObj1.Name);
            //Console.WriteLine(empObj1.Address);


            Employee empobj2 = new Employee();
            empobj2.ID = 1002;
            empobj2.Name = "praveenkumar";
            empobj2.Address = "hyderabad";

            //Console.WriteLine(empobj2.ID);
            //Console.WriteLine(empobj2.Name);
            //Console.WriteLine(empobj2.Address);

            // Creating generic List with Employee records
            List<Employee> empListObj = new List<Employee>();
            empListObj.Add(empObj1);
            empListObj.Add(empobj2);
            // Displaying employee records from list collection

            foreach (Employee emp in empListObj)
            {
                Console.WriteLine(emp.ID);
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Address);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
