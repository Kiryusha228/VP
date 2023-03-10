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
            var GL = new GenericList<string>();
            GL.Add("hello");
            GL.Add("my");
            GL.Add("world");
            GL.Add("apple");
            Console.WriteLine("До сортировки(string):");
            Console.WriteLine(GL.ToString());
            GL.BubbleSort();
            Console.WriteLine("После сортировки(string):");
            Console.WriteLine(GL.ToString());

            var GL2 = new GenericList<Figure>();
            GL2.Add(new Ring("ring", "red", 12, 3));
            GL2.Add(new Rhomb("rhomb", "red", 4));
            GL2.Add(new N_corner("Ncorner", "red", 3, 13));
            Console.WriteLine("До сортировки(figure):");
            Console.WriteLine(GL2.ToString());
            GL2.BubbleSort();
            Console.WriteLine("После сортировки(figure):");
            Console.WriteLine(GL2.ToString());
            Console.ReadLine();
        }
    }
}
