using DelegatesLib;

namespace DelegatesUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<float> list = new List<float>();
            list.Add(23.32f);
            list.Add(234.32f);
            list.Add(23.3232f);
            ActionDelegate.FirstTask(ActionDelegate.Mul, true, list);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            FuncDelegate.SecondTask(FuncDelegate.Mul, true, 3.5f);
        }

    }
}