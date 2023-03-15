using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Rhomb : Parallelogram
    {
        public Rhomb(string name, string color, double sideA) : base(name, color, sideA)
        {

        }

        public override double Perimeter
        {
            get
            {
                return SideA * 4;
            }
        }

        public override double Square
        {
            get
            {
                return SideA * SideA;
            }
        }


    }
}
