using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Оформление заказа ===");

            DateTime today = DateTime.Now;
            Console.WriteLine($"Сегодня: {today.ToShortDateString()}");

            Console.Write("\nВведите дату в свободном формате: ");
            string input1 = Console.ReadLine();
            if (DateTime.TryParse(input1, out DateTime date3))
            {
                Console.WriteLine($"Вы ввели: {date3.ToShortDateString()}");
            }
            else
            {
                Console.WriteLine("Ошибка: это не дата.");
            }

            Console.Write("\nВведите дату строго в формате ДД.ММ.ГГГГ: ");
            string input2 = Console.ReadLine();
            if (DateTime.TryParseExact(input2, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date4))
            {
                Console.WriteLine($"Дата принята: {date4.ToShortDateString()}");
            }
            else
            {
                Console.WriteLine("Ошибка: формат не соблюден (нужно ДД.ММ.ГГГГ).");
            }

            Console.ReadKey();
        }
    }
    }

