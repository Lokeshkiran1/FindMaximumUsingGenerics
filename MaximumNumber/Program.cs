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
            Console.WriteLine("welcome to maximum number identification: ");
            MaximumOfThreeNumbers maximumOfThreeNumbers = new MaximumOfThreeNumbers();
            Console.WriteLine("enter option:\n1.Maximum of integers\n2.Maximum among floating values\n" +
                "3.Maximum of string");
            int option = Convert.ToInt32(Console.ReadLine());

           switch(option)
            {
                case 1:
                    int var = maximumOfThreeNumbers.PrintMaximumNumber(20, 10, 30);
                    Console.WriteLine("maximum of three numbers: " + var);
                    break;
                    case 2:
                    double var1 = maximumOfThreeNumbers.MaximumFloatNumber(23.255, 35.3669, 25.5566);
                    Console.WriteLine("Maximum float number : "+var1);
                    break;
                case 3:
                    string str = maximumOfThreeNumbers.MaximumStringNumber("lokesh","Kiran","Lokeshks");
                    Console.WriteLine("maximum string is : "+str);
                    break;
                    default:
                    Console.WriteLine(" wrong option");
                    break;
            }
        }
    }
}
