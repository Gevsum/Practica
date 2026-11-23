using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число n: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int n))
            {
                int result = CalculateDifference(n);
                Console.WriteLine($"Результат: {result}");
            }
            else
            {
                Console.WriteLine("Ошибка: вы ввели не целое число.");
            }

            Console.ReadKey();
        }

        static int CalculateDifference(int n)
        {
            int difference = Math.Abs(n - 123);

            if (n > 123)
            {
                return difference * 3;
            }

            return difference;
        }
    }
}
