using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Rectangle : Parallelogram
    {
        public Rectangle(string name, string color, double sideA, double sideB) : base(name, color, sideA, sideB)
        {

        }

        public override double Square
        {
            get
            {
                return SideA*SideB;
            }
        }

    }
}
