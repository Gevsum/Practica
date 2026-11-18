using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_2_
{
    internal class Program
    {
        public class User
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public string RealName { get; set; }
            public string Email { get; set; }
            public int Age { get; set; }
            public DateTime RegistrationDate { get; set; }
            public bool IsOnline { get; set; }
            public void PrintInfo()
            {
                Console.WriteLine("--- Информация о пользователе ---");
                Console.WriteLine($"ID: {Id}");
                Console.WriteLine($"Никнейм: {Username}");
                Console.WriteLine($"Настоящее имя: {RealName}");
                Console.WriteLine($"Email: {Email}");
                Console.WriteLine($"Возраст: {Age}");
                Console.WriteLine($"Дата регистрации: {RegistrationDate.ToShortDateString()}");
                string status = IsOnline ? "В сети" : "Не в сети";
                Console.WriteLine($"Статус: {status}");
                
            }
        }
        
        
            static void Main(string[] args)
            {
                User user1 = new User
                {
                    Id = 1,
                    Username = "dany",
                    RealName = "Даниил Петухов",
                    Email = "Dany@gmail.ru",
                    Age = 25,
                    RegistrationDate = DateTime.Now,
                    IsOnline = false
                };

                user1.PrintInfo();

                Console.ReadKey();
            }
        }
    }


