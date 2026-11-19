using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Привет";
            string s2 = "привет";

            Console.WriteLine($"== : {s1 == s2}");
            Console.WriteLine($"!= : {s1 != s2}");
            Console.WriteLine($"Equals : {s1.Equals(s2)}");

            Console.WriteLine($"Compare : {string.Compare(s1, s2)}");
            Console.WriteLine($"CompareOrdinal : {string.CompareOrdinal(s1, s2)}");

            Console.WriteLine($"Contains : {s1.Contains("вет")}");
            Console.WriteLine($"IndexOf : {s1.IndexOf("вет")}");

            Console.ReadKey();
        }
    }
}
