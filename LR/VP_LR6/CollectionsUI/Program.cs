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
            da.Add(-1);
            da.Add(-2);
            da.Add(321);
            da.Add(-21);
            da.Add(2);
            Console.WriteLine("Массив");
            Console.WriteLine(da.ToString());

            da.Sort((x, y) => x.CompareTo(y));
            Console.WriteLine("После сортировки");
            Console.WriteLine(da.ToString());

            da.Filter((o) => Convert.ToInt32(o) < 0);
            Console.WriteLine("После фильтрации");
            Console.WriteLine(da.ToString());
        }
    }
}