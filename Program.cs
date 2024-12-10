using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// Определить колиество элементов в одномерном массиве
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] omas = { 10, 7, 8, 4, 3, 1, 6, 2 };
            Console.WriteLine($"Размер: {omas.Length}");
            string[] mas = { "Никита", "Катя", "Антон" };
            int size = mas.Length;
            Console.WriteLine($"Размер: {size}");
            Console.ReadKey();
        }
        
    }
}
