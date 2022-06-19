using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_in_Genric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ham Genrick list me only similar data rakhte h.

            // if list int h to only integer value dalege.
            // if list string h to only String value dalege.
            // if list double h to only Double value dalege.    
            // if list float h to only float value dalege.    

            List<int> obj = new List<int> {1,2,3,4,5,6,7,8,9};
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }

            List<string> names = new List<string>();
            names.Add("Ranu");
            names.Add("Panu");
            names.Add("Tanu");
            names.Add("Janu");
            names.Add("Siya");

            foreach (string item in names)
            {
                Console.WriteLine(item);
            }


            List<double> doubleData = new List<double>();
            doubleData.Add(563.00);
            doubleData.Add(45.00);
            doubleData.Add(63.00);
            doubleData.Add(43.00);
            doubleData.Add(5563.00);
            doubleData.Add(263.00);
            //doubleData.Add("fba"); ham double me string value nahi daal sakte.

            foreach (double item in doubleData)
            {
                Console.WriteLine(item);
            }



            Console.ReadKey();
        }
    }
}
