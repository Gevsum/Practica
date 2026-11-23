using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 5, 2, 8, 1, 9 };
            int[] array2 = { 7, 3, 6 };

            Console.WriteLine("Исходный массив 1: " + string.Join(", ", array1));
            Console.WriteLine("Исходный массив 2: " + string.Join(", ", array2));

            SortAscending(array1);
            Console.WriteLine("\nПо возрастанию: " + string.Join(", ", array1));

            SortDescending(array1);
            Console.WriteLine("По убыванию: " + string.Join(", ", array1));

            int[] merged = MergeArrays(array1, array2);
            Console.WriteLine("\nОбъединенный массив: " + string.Join(", ", merged));


            Console.ReadKey();
        }

        static void SortAscending(int[] arr)
        {
            Array.Sort(arr);
        }

        static void SortDescending(int[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
        }

        static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            Array.Copy(arr1, 0, result, 0, arr1.Length);
            Array.Copy(arr2, 0, result, arr1.Length, arr2.Length);
            SortAscending(result);
            return result;

            
        }
        
    }
}
