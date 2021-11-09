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


        public static string Discriminant()
        {
            Console.Write("Введите число a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите число c: ");
            int c = int.Parse(Console.ReadLine());

            double discriminant = (Power(b, 2) - 4 * a * c);
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant) / (2 * a));
                double x2 = (-b - Math.Sqrt(discriminant) / (2 * a));
                return $"x1 = {x1} | x2 = {x2}";
            }
            else if (discriminant == 0)
            {
                double x = (-b / (2 * a));
                return $"Дискриминант равен нулю | x = {x}";
            }
            else
            {
                return "Дискриминант меньше нуля";
            }
        }

        public static double Power(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }

            if (n % 2 == 0)
            {
                var p = Power(x, n / 2);
                return p * p;
            }
            else
            {
                return x * Power(x, n - 1);
            }
        }

       

    }
}
