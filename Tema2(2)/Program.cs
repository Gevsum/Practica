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
        }
        static void Main(string[] args)
        {
        }
    }
}
