using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====Крутое деление====");

            while (true)
            {
                try
                {
                    Console.WriteLine("\nВведите первое число:");
                    string input1 = Console.ReadLine();

                    Console.Write("Введите второе число:");
                    string input2 = Console.ReadLine();

                    double a = double.Parse(input1);
                    double b = double.Parse(input2);

                    if (b == 0)
                    {
                        throw new DivideByZeroException("НА НОЛЬ ДЕЛИТЬ НЕЛЬЗЯ");
                    }
                    double result = a / b;
                    Console.WriteLine($"Результат: {a}/{b}={result}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели буквы или символы вместо чисел.Попробуйте ещё раз");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка: {e.Message}");
                }
                finally 
                {
                    Console.WriteLine("_____Завершенно_____");
                }

            }
        }
    }
}
