using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Ring : Circle
    {

        private double _innerRadius;

        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Радиус должен быть больше 0");
                }
                else if (value >= Radius)
                {
                    throw new ArgumentOutOfRangeException("Внешний радиус должен быть меньше внутреннего");
                }
                else
                {
                    _innerRadius = value;
                }
            }
        }

        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * (Radius + InnerRadius);
            }
        }

        public override double Square
        {
            get
            {
                return Math.PI * (Math.Pow(Radius, 2) - Math.Pow(InnerRadius, 2)) ;
            }
        }

        public Ring(string name, string color, double radius, double innerRadius) : base(name, color, radius)
        {
            Radius = radius;
            InnerRadius = innerRadius;
        }
    }
}
