using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculator
    {
        public static double Addition(double firstNumber, double lastNumber)
        {
            return firstNumber + lastNumber;
        }

        public static double Substraction (double firstNumber, double lastNumber)
        {
            return firstNumber - lastNumber;
        }

        public static double Multiplication(double firstNumber, double lastNumber)
        {
            return firstNumber * lastNumber;
        }

        public static double Division(double firstNumber, double lastNumber)
        {
            if ( lastNumber != 0)
            {
                return firstNumber / lastNumber;
            }
            else
            {
                return -1;
            }
        }
    }
}
