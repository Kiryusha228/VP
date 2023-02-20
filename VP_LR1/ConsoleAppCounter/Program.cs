using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL = CounterLibrary;

namespace CounterUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string fullStr = Console.ReadLine();
            Console.WriteLine("Введите символ:");
            string symbol = Console.ReadLine();
            double percent = CL.Counter.Percent(fullStr, symbol);
            Console.WriteLine("Частота появления введенного символа: {0:f2}%", percent);
            Console.ReadKey();
        }
    }
}
