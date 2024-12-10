using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        /// <summary>
        /// Найти максимальное\минимальное значение массива
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] omas = { 10, 7, 9, -8, 13, -5 };
            int max = omas.Max();
            int min = omas.Min();
            Console.WriteLine($"Максимальное: {max}\nМинимальное: {min}");
            Console.ReadKey();
        }
    }
}
