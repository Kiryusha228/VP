using MatrixLib;
using System.Text.RegularExpressions;

namespace NewMatrixUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Matrix> list = new List<Matrix>();

            int exitKey = -1;
            while (exitKey != 1)
            {
                ShowMatrixs(list);
                HelpMenu();
                exitKey = Actions(list);
            }
        }

        static void HelpMenu()
        {
            Console.WriteLine("Действие:");
            Console.WriteLine();
            Console.WriteLine("[1] - Создать матрицу");
            Console.WriteLine("[2] - Клонировать матрицу");
            Console.WriteLine("[3] - Вывести информацию о матрице");
            Console.WriteLine("[4] - Вывести n первых элементов");
            Console.WriteLine("[5] - Сложить матрицы");
            Console.WriteLine("[6] - Вычесть матрицы");
            Console.WriteLine("[7] - Умножить матрицы");
            Console.WriteLine("Иначе - Выход");
            Console.WriteLine();
        }
        static int Actions(List<Matrix> list)
        {
            Console.Write("Выбор -> ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Создание матрицы:");
                        Console.Write("Количество строк: ");
                        uint rows = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("Количество столбцов: ");
                        uint cols = Convert.ToUInt32(Console.ReadLine());
                        list.Add(new Matrix(rows, cols));
                        Console.WriteLine("Элементы: ");
                        for (uint i = 0; i < list.Last().Rows; i++)
                        {
                            for (uint j = 0; j < list.Last().Columns; j++)
                            {
                                list.Last()[i, j] = double.Parse(Console.ReadLine());
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Клонирование матрицы:");
                        Console.Write("Введите номер матрицы: ");
                        int matrixNumber = int.Parse(Console.ReadLine());
                        list.Add((Matrix)list[matrixNumber].Clone());
                        //list.Add(new Matrix(list[matrixNumber]));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Информация о матрице:");
                        Console.Write("Введите номер матрицы: ");
                        int matrixNumber = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Информация о матрице:");
                        Console.WriteLine(list[matrixNumber].ToString());
                        Console.WriteLine("Enter - продолжить:");
                        Console.ReadLine();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("n первых элементов:");
                        Console.Write("Введите номер матрицы: ");
                        int matrixNumber = int.Parse(Console.ReadLine());
                        Console.Write("Введите число элементов: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("n первых элементов:");
                        Console.WriteLine(list[matrixNumber].ToString(n));
                        Console.WriteLine("Enter - продолжить:");
                        Console.ReadLine();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Сложить:");
                        Console.Write("Введите номер 1 матрицы: ");
                        int matrixNumber1 = int.Parse(Console.ReadLine());
                        Console.Write("Введите номер 2 матрицы: ");
                        int matrixNumber2 = int.Parse(Console.ReadLine());
                        list.Add(new Matrix(list[matrixNumber1] + list[matrixNumber2])) ;
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Вычесть:");
                        Console.Write("Введите номер 1 матрицы: ");
                        int matrixNumber1 = int.Parse(Console.ReadLine());
                        Console.Write("Введите номер 2 матрицы: ");
                        int matrixNumber2 = int.Parse(Console.ReadLine());
                        list.Add(new Matrix(list[matrixNumber1] - list[matrixNumber2]));
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Умножить:");
                        Console.Write("Введите номер 1 матрицы: ");
                        int matrixNumber1 = int.Parse(Console.ReadLine());
                        Console.Write("Введите номер 2 матрицы: ");
                        int matrixNumber2 = int.Parse(Console.ReadLine());
                        list.Add(new Matrix(list[matrixNumber1] * list[matrixNumber2]));
                        break;
                    }
                case 8:
                    {
                        list[0][0,0] = 999;
                        break;
                    }
                default:
                    {
                        return 1;
                    }
            }
            Console.Clear();
            return -1;
        }

        

        static void ShowMatrixs(List<Matrix> list) 
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i}:");
                Print(list[i]);
            }
        }
        static void Print(Matrix matrix) 
        {
            for (uint i = 0; i < matrix.Rows; i++)
            {
                for (uint j = 0; j < matrix.Columns; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}