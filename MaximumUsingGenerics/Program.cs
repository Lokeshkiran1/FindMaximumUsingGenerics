using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 112, 344, 432, 555, 678 };
            GenericsMaximum<int> generic = new GenericsMaximum<int>(intArray);


            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            GenericsMaximum<double> genericDouble = new GenericsMaximum<double>(doubleArray);


            string[] stringArray = { "apple", "peach", "Banana", "Grapes" };
            GenericsMaximum<string> genericString = new GenericsMaximum<string>(stringArray);

            Console.ReadKey();

        }
    }
}
