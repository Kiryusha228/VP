using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Traingle : N_corner
    {
        public Traingle(string name, string color, double side) : base(name, color, side, 3)
        {

        }

        public override double Square
        {
            get
            {
                return Side * Side * Math.Sqrt(3) / 4;
            }
        }
    }
}
