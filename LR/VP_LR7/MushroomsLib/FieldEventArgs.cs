using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushroomsLib
{
    public class FieldEventArgs : EventArgs
    {
        public string Name { get; }
        public int Mushrooms { get; }

        public FieldEventArgs(string name, int mushrooms)
        {
            Name = name;
            Mushrooms = mushrooms;
        }
    }
}
