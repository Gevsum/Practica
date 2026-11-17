using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_1
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        private double Dev(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
                return 0;
            }
            return a / b;
        }
        public double Divide(double a, double b)
        {
            return Dev(a, b);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalc = new Calculator();

            Console.Write("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(); 

            
            Console.WriteLine($"Сумма ({a} + {b}) = {myCalc.Add(a, b)}");
            Console.WriteLine($"Частное ({a} / {b}) = {myCalc.Divide(a, b)}");

            Console.ReadKey();
        }
    }
}
