using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public abstract class Figure
    {
        public string Name { get; private set; }

        public string Color { get; private set; }

        public abstract double Perimeter { get; }

        public abstract double Square { get; }

        public Figure()
        {

        }

        public Figure(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public override string ToString()
        {
            return $"\nФигура: {Name}\nЦвет: {Color}\nПериметр P = {Perimeter:N2}\nПлощадь S = {Square:N2}\n";
        }
    }
}
