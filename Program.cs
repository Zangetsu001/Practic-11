using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        /// <summary>
        /// Обнулить заданный диапозон элементов в одномерном массиве 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] omas = Input(size());
            Array.Clear(omas, 1, 3);
            Output(omas);
            Console.ReadKey();
        }
        static int size()
        {
            Console.Write("Размер одномерного массива: ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Ошибка");
            }
            return size;
        }
        static int[] Input(int size)
        {
            int[] omas = new int[size];
            for (int i = 0; i < omas.Length; i++)
            {
                Console.Write($"Введите {i + 1} значение: ");
                omas[i] = int.Parse(Console.ReadLine());
                
            }
            return omas;
        }
        static void Output(int[] omas)
        {
            foreach(var el in omas)
            {
                Console.WriteLine(el);
            }
        }

    }
}
