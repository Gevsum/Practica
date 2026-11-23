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
            string s1 = "Практика";
            string s2 = "практика";

            Console.WriteLine($"== : {s1 == s2}");
            Console.WriteLine($"!= : {s1 != s2}");
            Console.WriteLine($"Equals : {s1.Equals(s2)}");

            Console.WriteLine($"Compare : {string.Compare(s2, s1)}");
            Console.WriteLine($"CompareOrdinal : {string.CompareOrdinal(s1, s2)}");

            Console.WriteLine($"Contains : {s1.Contains("ика")}");
            Console.WriteLine($"IndexOf : {s1.IndexOf("ика")}");

            Console.ReadKey();
        }
    }
}
