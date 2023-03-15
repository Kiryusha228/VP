using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Parallelogram : Figure
    {
        private double _sideA;
        private double _sideB;
        private double _diag;

        public double SideA
        {
            get
            {
                return _sideA;
            }

            set
            {
                if (value > 0)
                {
                    _sideA = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Сторона должна быть больше 0");
                }
            }
        }

        public double SideB
        {
            get
            {
                return _sideB;
            }

            set
            {
                if (value > 0)
                {
                    _sideB = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Сторона должна быть больше 0");
                }
            }
        }

        public double Diag
        {
            get
            {
                return _diag;
            }

            set
            {
                
                if ((value < SideA + SideB) && (value !=0))
                {
                    _diag = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Диагональ должна быть меньше суммы сторон и не равна 0");
                }
            }
        }

        public override double Perimeter
        {
            get
            {
                return (SideA + SideB ) * 2;
            }
        }

        public override double Square
        {
            get
            {
                double p = (SideA + SideB + Diag) /2;
                return 2*Math.Sqrt(p*(p-SideA)*(p-SideB)*(p-Diag));
            }
        }

        public Parallelogram(string name, string color, double sideA, double sideB, double diag) : base(name, color)
        {
            SideA = sideA;
            SideB = sideB;
            Diag = diag;
        }
        protected Parallelogram(string name, string color, double sideA, double sideB) : base(name, color)
        {
            SideA = sideA;
            SideB = sideB;
        }

        protected Parallelogram(string name, string color, double sideA) : base(name, color)
        {
            SideA = sideA;
        }
    }
}
