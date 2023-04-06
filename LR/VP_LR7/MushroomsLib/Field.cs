using System;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace MushroomsLib
{
    public class Field
    {
        public int Mushrooms { get; set; }
        private List<MushroomMans> _mushroomMans;

        EventHandler<FieldEventArgs> lambdaAdd;
        EventHandler<FieldEventArgs> lambdaCollect;
        EventHandler<FieldEventArgs> lambdaRemove;

        public int GetIndex(MushroomMans mushroomMan)
        {
            return _mushroomMans.FindIndex(m => m == mushroomMan);
        }


        private void Subscribe(int i)
        {
            lambdaAdd = (object? sender, FieldEventArgs results)
                => Console.WriteLine($"На поляну пришёл грибник {results.Name}. " +
                $"В данный момент на поляне {results.Mushrooms} грибов");

            lambdaCollect = (object? sender, FieldEventArgs results)
                => Console.WriteLine($"Грибник {results.Name} собрал {results.Mushrooms} грибов");

            lambdaRemove = (object? sender, FieldEventArgs results)
                => Console.WriteLine($"Грибник {results.Name} ушел с поляны. " +
                $"На поляне осталось {results.Mushrooms} грибов");

            _mushroomMans[i].OnNewMushroomManLambda += lambdaAdd;
            _mushroomMans[i].OnRemoveMushroomManLambda += lambdaRemove;
            _mushroomMans[i].OnCollectMushroomsLambda += lambdaCollect; 

            //_mushroomMans[i].OnNewMushroomMan += ConsoleInform;
            //_mushroomMans[i].OnRemoveMushroomMan += ConsoleInformRemove;
            //_mushroomMans[i].OnCollectMushrooms += ConsoleInformCollect;
        }

        private void Unsubscribe(int i)
        {
            _mushroomMans[i].OnNewMushroomManLambda -= lambdaAdd;
            _mushroomMans[i].OnRemoveMushroomManLambda -= lambdaCollect;
            _mushroomMans[i].OnCollectMushroomsLambda -= lambdaRemove;

            //_mushroomMans[i].OnNewMushroomMan -= ConsoleInform;
            //_mushroomMans[i].OnRemoveMushroomMan -= ConsoleInformRemove;
            //_mushroomMans[i].OnCollectMushrooms -= ConsoleInformCollect;
        }

        public Field(int mushrooms)
        {
            Mushrooms = mushrooms;
            _mushroomMans = new List<MushroomMans>();
            
        }

        public void AddMushroomMan(MushroomMans mushroomMan) 
        {
            _mushroomMans.Add(mushroomMan);
            int i = GetIndex(mushroomMan);
            Subscribe(i);
            _mushroomMans[i].Come(Mushrooms);
        }

        public void RemoveMushroomMan(MushroomMans mushroomMan)
        {
            int i = GetIndex(mushroomMan);
            _mushroomMans[i].GoAway(Mushrooms);
            Unsubscribe(i);
            _mushroomMans.RemoveAt(i);
        }

        private void RemoveAllMushroomMans()
        {
            int count = _mushroomMans.Count();
            for (int i = 0; i < count; i++)
            {
                RemoveMushroomMan(_mushroomMans[0]);
            }
        }

        public void CollectMushrooms(int count, MushroomMans mushroomMan)
        {
            int i = GetIndex(mushroomMan);
            if (Mushrooms - count > 0)
            {
                Mushrooms -= count;
                _mushroomMans[i].Collect(count);
                return;
            }
            count = Mushrooms;
            Mushrooms = 0;
            _mushroomMans[i].Collect(count);

            RemoveAllMushroomMans();
        }

        void ConsoleInform(FieldEventArgs results)
        {
            Console.WriteLine($"На поляну пришёл грибник {results.Name}. В данный момент на поляне {results.Mushrooms} грибов");
        }

        void ConsoleInformCollect(FieldEventArgs results)
        {
            Console.WriteLine($"Грибник {results.Name} собрал {results.Mushrooms} грибов");
        }

        void ConsoleInformRemove(FieldEventArgs results)
        {
            Console.WriteLine($"Грибник {results.Name} ушел с поляны. На поляне осталось {results.Mushrooms} грибов");
        }
    }
}