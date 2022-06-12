using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Student
    {
        // indexers allow our object use to be like array.

        private int[] Age = new int[3];  // declare a array.
        public int this[int index]
        {
            // here this means object.
            set { 

               if(index >= 0 && index < Age.Length)
                {
                    if(value > -1)
                    {
                        Age[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Value can not be zero");
                    }
                }
                else
                {
                    Console.WriteLine("Please give valid index");
                }
                
            }
            get { 
                return Age[index];
            }
        }

        public int this[int index,int i]
        {
            set { 
                Age[index] = value+i;
            }
            get {
                return Age[index];
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student();
            //obj[0] = 10;
            //obj[1] = 20;
            //obj[2] = 30;
            //obj[3] = 50;
            //Console.WriteLine(obj[0]);
            //Console.WriteLine(obj[1]);
            //Console.WriteLine(obj[2]);
            //Console.WriteLine(obj[3]);


            //obj[-1] = 10;
            //obj[1] = -4;

            //--------------------------------------;
            obj[0, 1] = 10; 
            obj[1, 2] = 20;
            obj[2, 3] = 30;
            Console.WriteLine(obj[0]);
            Console.ReadKey();

        }
    }
}
