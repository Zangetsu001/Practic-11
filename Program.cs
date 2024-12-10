using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] omas = { "Яблоко", "Груша", "Ананас" };
            Array.Reverse(omas);
            foreach(var el in omas)
            {
                Console.WriteLine(el);
            }
            Array.Sort(omas);
            foreach(var el in omas)
            {
                Console.WriteLine(el);
            }
            Console.ReadKey();
        }
    }
}
