namespace ExceptionsLib
{
    public class Item
    {
        private int _article;
        private string _name;
        private string _color;
        private double _price;

        public int Article
        {
            get 
            { 
                return _article;
            }
            private set 
            { 
                _article = value; 
            }
        }
        public string Name
        {
            get 
            {
                return _name!;
            }
            private set
            {
                _name = value;
            }
        }

        public string Color
        {
            get 
            { 
                return _color!;
            }
            private set
            {
                _color = value;
            }
        }

        public double Price
        {
            get 
            {
                return _price;
            }
            private set
            {
                _price = value;
            }
        }

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
    }
}