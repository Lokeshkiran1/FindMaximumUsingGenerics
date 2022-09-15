using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumber
{
    internal class MaximumOfThreeNumbers
    {
        public T PrintMaximumNumber<T>(T num1, T num2, T num3) where T : IComparable
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0
                || num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) > 0
                || num1.CompareTo(num2) > 0 && num1.CompareTo(num3) >= 0)
            {
                return num1;
            }
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0
                || num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) > 0
                || num2.CompareTo(num1) > 0 && num2.CompareTo(num3) >= 0)
            {
                return num2;
            }
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0
                || num3.CompareTo(num1) >= 0 && num3.CompareTo(num2) > 0
                || num3.CompareTo(num1) > 0 && num3.CompareTo(num2) >= 0)
            {
                return num3;
            }
            return num1;

        }

        public double MaximumFloatNumber(double firstValue, double secondValue, double thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        }
    }
}
