using MushroomsLib;
using System.Xml.Linq;

namespace MushroomsUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Field field = new Field(50);
            MushroomMans Gena = new MushroomMans("Gena");
            MushroomMans Kolya = new MushroomMans("Kolya");
            MushroomMans Nikita = new MushroomMans("Nikita");
            MushroomMans Jenya = new MushroomMans("Jenya");
            MushroomMans Misha = new MushroomMans("Misha");

            field.AddMushroomMan(Gena);
            field.CollectMushrooms(4, Gena);
            field.AddMushroomMan(Kolya);
            field.AddMushroomMan(Nikita);
            field.CollectMushrooms(12, Nikita);
            field.AddMushroomMan(Jenya);
            field.AddMushroomMan(Misha);
            field.CollectMushrooms(21, Jenya);
            field.RemoveMushroomMan(Jenya);
            field.CollectMushrooms(56, Gena);
        }
    }
}