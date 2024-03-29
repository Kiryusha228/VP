﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using StudentLib;
using Group = StudentLib.Group;


namespace StudentsUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>();
            int exitKey = -1;
            while (exitKey != 1)
            {
                
                ShowGroups(groups);
                HelpMenuGroups();
                exitKey = GroupActions(groups);

            }        
        }

        static void pr()
        {
            Console.Clear();
            Console.WriteLine("Введите стороку");
            string str = Console.ReadLine();
            StringExtensions.StringInfo info = new StringExtensions.StringInfo();
            info = str.Info();
            Console.WriteLine($"Длинна строки: {info.Lenght}");
            Console.WriteLine($"Количество букв: {info.LetterCount}");
            Console.WriteLine($"Количество цифр: {info.DigitCount}");
        }

        static void HelpMenuGroups()
        {
            Console.WriteLine("Действие:");
            Console.WriteLine();
            Console.WriteLine("[1] - Добавить группу");
            Console.WriteLine("[2] - Информация о группе");
            Console.WriteLine("[3] - PR");
            Console.WriteLine("Иначе - Выход");
            Console.WriteLine();
        }

        static int GroupActions(List<Group> groups)
        {
            Console.Write("Выбор -> ");
            int choice = Convert.ToInt32(Console.ReadLine());
            int groupNubmer;
            switch (choice)
            {
                case 1:
                    {
                        Console.Write("Введите номер группы: ");
                        groupNubmer = Convert.ToInt32(Console.ReadLine());
                        groups.Add(new Group(groupNubmer));
                        break;
                    }
                case 2:
                    {
                        Console.Write("Введите ПОРЯДКОВЫЙ номер группы: ");
                        groupNubmer = Convert.ToInt32(Console.ReadLine());
                        GetGroupInfoAndActions(groups, groupNubmer - 1 );
                        break;
                    }
                case 3:
                    {
                        pr();
                        Console.WriteLine();
                        Console.WriteLine("Нажмите любую кнопку чтобы продолжить");
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

        static void GetGroupInfoAndActions(List<Group> groups, int groupNumber)
        {
            Console.Clear();
            int exitKey = -1;
            while (exitKey != 1)
            {
                Console.WriteLine(groups[groupNumber].GetInfo());
                HelpMenuOneGroup();
                exitKey = OneGroupActions(groups[groupNumber]);
            }
           

        }

        static int OneGroupActions(Group group)
        {
            int id, studentNumber, studentNumber2;
            string name, surname, pat, adress, phoneNumber;
            DateTime bornDate;
            Console.Write("Выбор -> ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Добавление студента:");
                        Console.Write("Введите номер зачетки: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите фамилию: ");
                        surname = Console.ReadLine();
                        Console.Write("Введите имя: ");
                        name = Console.ReadLine();
                        Console.Write("Введите отчество: ");
                        pat = Console.ReadLine();
                        Console.Write("Введите дату рождения: ");
                        bornDate = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Введите адрес: ");
                        adress = Console.ReadLine();
                        Console.Write("Введите номер телефона: ");
                        phoneNumber = Console.ReadLine();
                        group.Add(new Student(id, name, surname, pat, bornDate, adress, phoneNumber));
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Удаление студента:");
                        Console.Write("Введите номер студента: ");
                        studentNumber = Convert.ToInt32(Console.ReadLine());
                        group.Remove(studentNumber - 1);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Сравнение студентов:");
                        Console.Write("Введите номер зачетки первого студента: ");
                        studentNumber = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.Write("Введите номер зачетки второго студента: ");
                        studentNumber2 = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.Clear();
                        if (group[studentNumber].Equals(group[studentNumber2]))
                        {
                            Console.WriteLine($"Информация о студентах с номерами зачеток {studentNumber} и {studentNumber2} совпадает");

                        }
                        else
                        {
                            Console.WriteLine($"Информация о студентах с номерами зачеток {studentNumber} и {studentNumber2} совпадает");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Нажмите любую кнопку чтобы продолжить");
                        Console.ReadLine();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Информация о студенте:");
                        Console.Write("Введите номер зачетки студента: ");
                        studentNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine(group[studentNumber].ToString());
                        Console.WriteLine();
                        Console.WriteLine("Нажмите любую кнопку чтобы продолжить");
                        Console.ReadLine();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Информация:");
                        Console.Write("Введите адрес общежития: ");
                        adress = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(group.GetStudentsFromOneHouse(adress));
                        Console.WriteLine();
                        Console.WriteLine("Нажмите любую кнопку чтобы продолжить");
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

        static void HelpMenuOneGroup()
        {
            Console.WriteLine("Действие:");
            Console.WriteLine();
            Console.WriteLine("[1] - Добавить студента");
            Console.WriteLine("[2] - Удалить студента");
            Console.WriteLine("[3] - Сравнить информацию о студентах");
            Console.WriteLine("[4] - Получить полную информацию о студенте");
            Console.WriteLine("[5] - Студенты из указаного общежития");
            Console.WriteLine("Иначе - Выход");
            Console.WriteLine();
        }

        static void ShowGroups(List<Group> groups)
        {
            if (groups.Count == 0)
            {
                Console.WriteLine("Cписок групп пуст");
            }
            else
            {
                Console.WriteLine("Список групп:");
                Console.WriteLine();
                for (int i = 0; i < groups.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {groups[i].GroupNumber}");
                }
            }
            Console.WriteLine();
        }
    }
}
