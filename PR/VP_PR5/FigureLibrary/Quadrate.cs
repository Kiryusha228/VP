using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Quadrate : N_corner
    {
        public Quadrate(string name, string color, double side) : base(name, color, side, 4)
        {

        }

        public override double Square
        {
            get
            {
                return Side * Side;
            }
        }
    }
}
