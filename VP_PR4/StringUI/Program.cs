using StringLib;
using System.Collections.Generic;

namespace StringUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exitKey = -1;
            while (exitKey != 1)
            {
                HelpMenu();
                exitKey = Actions();
            }
        }

        static void HelpMenu()
        {
            Console.WriteLine("Действие:");
            Console.WriteLine();
            Console.WriteLine("[1] - Удалить из строки подстроку");
            Console.WriteLine("[2] - Удалить лишние пробелы");
            Console.WriteLine("[3] - Отсортировать и удалить пробелы");
            Console.WriteLine("[4] - Вставить подстроку после символа");
            Console.WriteLine("[5] - Дополнить пробелами");
            Console.WriteLine("[6] - Конвертировать в 2сс");
            Console.WriteLine("Иначе - Выход");
            Console.WriteLine();
        }
        static int Actions()
        {
            Console.Write("Выбор -> ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Удалить из строки подстроку:");
                        Console.Write("Строка: ");
                        string str1 = Console.ReadLine();
                        Console.Write("Подстрока: ");
                        string str2 = Console.ReadLine();
                        Console.WriteLine("Результат:");
                        Console.WriteLine(StringRegular.RemoveAll(str1, str2));
                        Console.WriteLine();
                        Console.WriteLine("[Enter] - продолжить");
                        Console.ReadLine();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Удалить лишние пробелы:");
                        Console.Write("Строка: ");
                        string str1 = Console.ReadLine();
                        Console.WriteLine("Результат:");
                        Console.WriteLine(StringRegular.RemoveSpace(str1));
                        Console.WriteLine();
                        Console.WriteLine("[Enter] - продолжить");
                        Console.ReadLine();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Отсортировать и удалить пробелы:");
                        Console.Write("Строка: ");
                        string str1 = Console.ReadLine();
                        Console.WriteLine("Результат:");
                        Console.WriteLine(StringRegular.SortWords(str1));
                        Console.WriteLine();
                        Console.WriteLine("[Enter] - продолжить");
                        Console.ReadLine();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Вставить подстроку после символа:");
                        Console.Write("Строка: ");
                        string str1 = Console.ReadLine();
                        Console.Write("Подстрока: ");
                        string str2 = Console.ReadLine();
                        Console.Write("Cимвол: ");
                        char c = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("Результат:");
                        Console.WriteLine(StringBuilderRegular.AddString(str1, str2, c));
                        Console.WriteLine();
                        Console.WriteLine("[Enter] - продолжить");
                        Console.ReadLine();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Дополнить строку пробелами:");
                        Console.Write("Строка 1: ");
                        string str1 = Console.ReadLine();
                        Console.Write("Строка 2: ");
                        string str2 = Console.ReadLine();
                        Console.WriteLine("Результат:");
                        Console.WriteLine(StringBuilderRegular.AddSpaces(str1, str2));
                        Console.WriteLine();
                        Console.WriteLine("[Enter] - продолжить");
                        Console.ReadLine();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Конвертировать в 2сс:");
                        Console.Write("Число: ");
                        string str1 = Console.ReadLine();
                        Console.WriteLine("Результат:");
                        Console.WriteLine(StringBuilderRegular.Convert10To2(str1));
                        Console.WriteLine();
                        Console.WriteLine("[Enter] - продолжить");
                        Console.ReadLine();
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
    }
}