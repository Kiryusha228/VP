using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FigureLibrary
{
    public class N_corner : Figure
    {
        private double _side;

        private int _countOfCorners;

        public double Side
        {
            get
            {
                return _side;
            }

            set
            {
                if (value > 0)
                {
                    _side = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Сторона должна быть больше 0");
                }
            }
        }

        public int CountOfCorners
        {
            get
            {
                return _countOfCorners;
            }
            set
            {
                if (value > 2)
                {
                    _countOfCorners = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Количество углов не может быть меньше 3");
                }
            }
        }

        public override double Perimeter
        {
            get
            {
                return Side * CountOfCorners;
            }
        }

        public override double Square
        {
            get
            {
                return (CountOfCorners * Math.Pow(Side,2))/(4*Math.Tan(Math.PI/CountOfCorners)) ;
            }
        }

        public N_corner(string name, string color, double side, int countOfCorners) : base(name, color)
        {
            Side = side;
            _countOfCorners = countOfCorners;
        }
    }
}
