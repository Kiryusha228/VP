using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Ellipse : Circle
    {
        private double _radiusB;

        public double RadiusB
        {
            get
            {
                return _radiusB;
            }

            set
            {
                if (value > 0)
                {
                    _radiusB = value;
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
                return 2 * Math.PI * Math.Sqrt((Math.Pow(Radius, 2) + Math.Pow(RadiusB, 2))/2);
            }
        }

        public override double Square
        {
            get
            {
                return Math.PI * Radius * RadiusB;
            }
        }
        public Ellipse(string name, string color, double radius, double radiusB) : base(name, color, radius)
        {
            RadiusB = radiusB;
        }
    }
}
