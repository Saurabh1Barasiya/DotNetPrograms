using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genric_class
{
    class Employee
    {
        int val;
        public Employee(int v)
        {
            this.val = v;
        }
        public int show()
        {
            return val;
        }
    }

    class E1<T>
    {
        T sal;

        T box;
        public T Box {
            set { box = value; }
            get { return box; }
        }
        public E1(T a){
            this.sal = a;
        }

        public T show()
        {
            return sal;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee(5);
            //Employee obj1 = new Employee("bbfjbfj");


            Console.WriteLine(obj.show());
            //Console.WriteLine(obj1.show());

            E1<int> myobj  = new E1<int>(10);
            E1<string> myobj1  = new E1<string>("saurah");
            Console.WriteLine(myobj.show());
            Console.WriteLine(myobj1.show());
            myobj1.Box = "Barasiya";
            Console.WriteLine(myobj1.Box);
            Console.ReadKey();
        }
    }
}
