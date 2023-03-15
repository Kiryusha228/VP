using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AL = ArrayLibrary;

namespace ArrayUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxOfDiag;
            int[,] arr = new int[10,10];
            arr = AL.Arr.Inicialize(arr.GetLength(0), arr.GetLength(1) ,-10, 10);
            int[] sumArr = new int[arr.GetLength(0)];
            int[] multArr = new int[arr.GetLength(0)];
            
            sumArr = AL.Arr.SumOfLines(arr);
            multArr = AL.Arr.MultipleOfRows(arr);
            maxOfDiag = AL.Arr.MaxOfDiag(arr);

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0}\t", arr[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Суммы строк:");
            for (int i = 0; i < sumArr.GetLength(0); i++)
            {
                    Console.Write("{0} ", sumArr[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Произведения столбцов:");
            for (int i = 0; i < multArr.GetLength(0); i++)
            {
                Console.Write("{0} ", multArr[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Максимальный элемент главной диагонали: {0}", maxOfDiag);

            Console.ReadLine();
        }
    }
}
