using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMathLibrary;
namespace TestAppnew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            math.PrintHello();
            math.ShowMessage("Как дела?");
            Console.WriteLine();

            int sum = math.Add(10, 5);
            Console.WriteLine($"Результат сложения (int): {sum}");

            double div = math.Divide(10, 4);
            Console.WriteLine($"Результат деления (double): {div}");

            bool isEven = math.IsEven(10);
            Console.WriteLine($"Число 10 четное? (bool): {isEven}");

            Console.ReadKey();
        }
    }
}
