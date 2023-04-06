using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MushroomsLib
{
    public class MushroomMans
    {
        public string Name { get; private set; }

        public delegate void FieldNewMushroomManEvent(FieldEventArgs results);
        public delegate void FieldCollectMushroomsEvent(FieldEventArgs results);
        public delegate void FieldRemoveMushroomManEvent(FieldEventArgs results);

        public event FieldNewMushroomManEvent? OnNewMushroomMan;
        public event FieldCollectMushroomsEvent? OnCollectMushrooms;
        public event FieldRemoveMushroomManEvent? OnRemoveMushroomMan;

        public event EventHandler<FieldEventArgs> OnNewMushroomManLambda;
        public event EventHandler<FieldEventArgs> OnCollectMushroomsLambda;
        public event EventHandler<FieldEventArgs> OnRemoveMushroomManLambda;



        public MushroomMans(string name) 
        {
            Name = name;
        }

        public void Come(int mushrooms)
        {
            OnNewMushroomManLambda?.Invoke(this, new FieldEventArgs(Name, mushrooms));
            //OnNewMushroomMan?.Invoke(new FieldEventArgs(Name, mushrooms));
        }

        public void Collect(int mushrooms)
        {
            OnCollectMushroomsLambda?.Invoke(this, new FieldEventArgs(Name, mushrooms));
            //OnCollectMushrooms?.Invoke(new FieldEventArgs(Name, mushrooms));
        }

        public void GoAway(int mushrooms)
        {
            OnRemoveMushroomManLambda?.Invoke(this, new FieldEventArgs(Name, mushrooms));
            //OnRemoveMushroomMan?.Invoke(new FieldEventArgs(Name, mushrooms));
        } 
    }
}
