using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibrary
{
    public static class Arr
    {
        public static int[,] Inicialize(int m, int n, int minRandElem, int maxRandElem)
        {
            int[,] arr = new int[m, n];
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(minRandElem, maxRandElem);
                }
            }
            return arr;
        }
        public static int[] SumOfLines(int[,] arr)
        {
            int[] sumArr = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sumArr[i] += arr[i, j];
                }
            }
            return sumArr;
        }

        public static int[] MultipleOfRows(int[,] arr)
        {
            int[] multArr = new int[arr.GetLength(1)];

            for (int i = 0; i < multArr.GetLength(0); i++)
            {
                multArr[i] = 1;
            }

            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    multArr[i] *= arr[i, j];
                }
            }
            return multArr;
        }

        public static int MaxOfDiag(int[,] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (max < arr[i,i])
                {
                    max = arr[i,i];
                }
            }
            return max;
        }
    }
}
