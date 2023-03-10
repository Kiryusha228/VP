using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Circle : Figure
    {
        private double _radius;

        public double Radius
        {
            get
            {
                return _radius;
            }

            set
            {
                if (value > 0)
                {
                    _radius = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Радиус должен быть больше 0");
                }
            }
        }

        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * Radius;
            }
        }

        public override double Square
        {
            get
            {
                return Math.PI * Math.Pow(Radius,2); //* RadiusB;
            }
        }

        public Circle(string name, string color, double radius) : base(name, color)
        {
            Radius = radius;
        }

    }
}
