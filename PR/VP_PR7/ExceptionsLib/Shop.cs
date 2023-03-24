using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsLib
{
    public class Shop
    {
        private List<Item> _items;

        public Shop() 
        {
            _items = new List<Item>();
        }

        public void Add(Item item) 
        {
            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Article == item.Article)
                {
                    throw new ExistingItemCodeException(item);
                }
            }

            _items.Add(item);
        }
    }
}
