using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace About_Interface
{
    // interface ke ander sab kuch public hota h.
    // yaha interface keyword ka use hota h.
    // I prefix me use karte h.

    interface Isound
    {
        void Sound();
    }

    class person : Isound
    {
        public void Sound()
        {
            Console.WriteLine("This ia a person voice");
        }
    }

    class Animal : Isound
    {
        public void Sound()
        {
            Console.WriteLine("This ia a Animal voice");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            person obj = new person();
            obj.Sound();
            Animal objAnimal = new Animal();
            objAnimal.Sound();

            Console.ReadKey();

        }
    }
}
