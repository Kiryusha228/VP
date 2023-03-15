using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLibrary;

namespace FigureUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure F = default(Figure);
            int choice = 0;
            while (choice != 1)
            {
                Console.Clear();
                while (F == default(Figure))
                {
                    HelpMenu();
                    F = GetFigure();
                }
                choice = ShowFigure(F);
                F = default(Figure);
            }
            
        }

        static void HelpMenu()
        {
            Console.WriteLine("Выберите фигуру:");
            Console.WriteLine();
            Console.WriteLine("Окружности:");
            Console.WriteLine();
            Console.WriteLine("[1] - Круг");
            Console.WriteLine("[2] - Эллипс");
            Console.WriteLine("[3] - Кольцо");
            Console.WriteLine();
            Console.WriteLine("Прямоугольные параллелограммы:");
            Console.WriteLine();
            Console.WriteLine("[4] - Параллелограмм");
            Console.WriteLine("[5] - Прямоугольник");
            Console.WriteLine("[6] - Ромб");
            Console.WriteLine();
            Console.WriteLine("Правильные N-угольники");
            Console.WriteLine();
            Console.WriteLine("[7] - N-угольник");
            Console.WriteLine("[8] - Квадрат");
            Console.WriteLine("[9] - Треугольник");
            Console.WriteLine();
            Console.Write("Выбор -> ");
        }

        static Figure GetFigure()
        {
            Figure F;
            int countOfCorners;
            double radiusA, radiusB, sideA, sideB, diag;
            string color;
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Круг:");
                        Console.Write("Введите радиус: ");
                        radiusA = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите цвет фигуры: ");
                        color = Console.ReadLine();
                        return F = new Circle("Кружочек", color, radiusA);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Эллипс:");
                        Console.Write("Введите вертикальный радиус: ");
                        radiusA = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите горизонтальный радиус: ");
                        radiusB = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите цвет фигуры: ");
                        color = Console.ReadLine();
                        return F = new Ellipse("Элипсик", color, radiusA, radiusB);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Кольцо:");
                        Console.Write("Введите внешний радиус: ");
                        radiusA = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите внутренний радиус: ");
                        radiusB = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите цвет фигуры: ");
                        color = Console.ReadLine();
                        return F = new Ring("Колечко", color, radiusA, radiusB);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Прямоугольник:");
                        Console.Write("Введите первую сторону: ");
                        sideA = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите вторую сторону: ");
                        sideB = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите диагональ: ");
                        diag = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите цвет фигуры: ");
                        color = Console.ReadLine();
                        return F = new Parallelogram("Грамм", color, sideA, sideB, diag);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Прямоугольник:");
                        Console.Write("Введите первую сторону: ");
                        sideA = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите вторую сторону: ");
                        sideB = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите цвет фигуры: ");
                        color = Console.ReadLine();
                        return F = new Rectangle("Прямоугольничек", color, sideA, sideB);
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Ромб:");
                        Console.Write("Введите сторону: ");
                        sideA = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите цвет фигуры: ");
                        color = Console.ReadLine();
                        return F = new Rhomb("Ромбик", color, sideA);
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("N-угольник:");
                        Console.Write("Введите сторону: ");
                        sideA = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите количество углов: ");
                        countOfCorners = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите цвет фигуры: ");
                        color = Console.ReadLine();
                        return F = new N_corner("Прямоугольничек", color, sideA, countOfCorners);
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Квадрат:");
                        Console.Write("Введите сторону: ");
                        sideA = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите цвет фигуры: ");
                        color = Console.ReadLine();
                        return F = new Quadrate("Прямоугольничек", color, sideA);
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Треугольник:");
                        Console.Write("Введите сторону: ");
                        sideA = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите цвет фигуры: ");
                        color = Console.ReadLine();
                        return F = new Traingle("Прямоугольничек", color, sideA);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Некорректное число, выберете фигуру заново!");
                        Console.WriteLine();
                        return default(Figure);
                        break;
                    }
            }
        }

        static int ShowFigure(Figure F)
        {
            Console.WriteLine(F.ToString());
            Console.WriteLine("[1] - выход");
            Console.WriteLine("Иначе - Начать заново");
            Console.WriteLine();
            Console.Write("Выбор -> ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
