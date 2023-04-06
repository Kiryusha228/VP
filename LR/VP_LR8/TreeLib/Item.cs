using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeLib
{
    public class Item : IComparable<Item>
    {


        public int Article { get; private set; }
        public string Name { get; private set; }
        public string Color { get; private set; }
        public double Price { get; private set; }



        public Item(int article, string name, string color, double price)
        {
            Article = article;
            Name = name;
            Color = color;
            Price = price;
        }
        public override string ToString()
        {
            return $"Артикул: {Article}, Наименование: {Name}, Цвет: {Color}, Цена: {Price}";
        }

        public int CompareTo(Item other)
        {
            return this.Article.CompareTo(other.Article);
        }
    }
}
