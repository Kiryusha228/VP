using CollectionsLib;
using System.Collections.ObjectModel;

namespace CollectionsUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> da = new DynamicArray<int>();
            da.Add(1);
            da.Add(2);
            da.Add(3);
            Console.WriteLine("Добавление");
            Console.WriteLine(da.ToString());
            Console.WriteLine("Количество: " + da.Count);
            Console.WriteLine("Вставка");
            da.Insert(33, 2);
            Console.WriteLine(da.ToString());
            Console.WriteLine("Количество: " + da.Count);
            Console.WriteLine("Удаление");
            da.RemoveAt(2);
            Console.WriteLine(da.ToString());
            Console.WriteLine("Количество: " + da.Count);
            Console.WriteLine("Удаление со сдвигом");
            da.RemoveAtAndShift(1);
            Console.WriteLine(da.ToString());
            Console.WriteLine("Количество: " + da.Count);
            Console.WriteLine("Добавление коллекции");
            Collection<int> dinosaurs = new Collection<int>();
            dinosaurs.Add(555);
            dinosaurs.Add(333);
            dinosaurs.Add(55555);
            dinosaurs.Add(223);
            da.Add(dinosaurs);
            Console.WriteLine(da.ToString());
            Console.WriteLine("Количество: " + da.Count);

        }
    }
}