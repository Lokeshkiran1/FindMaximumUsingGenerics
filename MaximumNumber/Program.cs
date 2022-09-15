using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaximumOfThreeNumbers maximumOfThreeNumbers = new MaximumOfThreeNumbers();
            int var=maximumOfThreeNumbers.PrintMaximumNumber(20,10,30);
            Console.WriteLine("maximum of three numbers: "+var);
        }
    }
}
