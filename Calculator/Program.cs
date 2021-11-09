using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        public static double firstNumber { get; set; }

        public static double lastNumber { get; set; }

        public static char action { get; set; }
        static void Main(string[] args)
        {
            while(action != 'e')
            {             
                ListCommand();
                Console.Write("Введите команду: ");
                action = Convert.ToChar(Console.ReadLine());

                switch (action)
                {
                    case '+':
                        EnterData();
                        Console.WriteLine("Результат: " + Calculator.Addition(firstNumber, lastNumber));
                        break;
                    case '-':
                        EnterData();
                        Console.WriteLine("Результат: " + Calculator.Substraction(firstNumber, lastNumber));
                        break;
                    case '*':
                        EnterData();
                        Console.WriteLine("Результат: " + Calculator.Multiplication(firstNumber, lastNumber));
                        break;
                    case '/':
                        EnterData();
                        Console.WriteLine("Результат: " + Calculator.Division(firstNumber, lastNumber));
                        break;
                    case 'r':                       
                        Console.Write("Введите число : ");
                        int value = int.Parse(Console.ReadLine());
                        Console.Write("Введите степень числа: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Результат: " + Calculator.Power(value, n));
                        break;
                    case 'd':                      
                        Console.WriteLine(Calculator.Discriminant());
                        break;
                    case 'e':
                        Process.GetCurrentProcess().Kill();
                        break;
                }

            }            
        }

      
        static void EnterData()
        {
            Console.Write("Введите первое число: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            lastNumber = Convert.ToDouble(Console.ReadLine());
        }

        public static void ListCommand()
        {

            Console.WriteLine("+ | Введите для сложения" );
            Console.WriteLine("- | Введите для вычитания");
            Console.WriteLine("* | Введите для умножения");
            Console.WriteLine("/ | Введите для деления"  );
            Console.WriteLine("r | Введите для возведения числа в степень");
            Console.WriteLine("d | Введите для нахождения дискриминанта");
        }

        

    }
}
